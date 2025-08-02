using System;
using System.Collections;
using System.Globalization;
using Tekla.Structures.Datatype;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Distance = Tekla.Structures.Datatype.Distance;
using LibreriaOMBIM;

namespace LibreriaOMBIM.Armaduras
{
    public sealed class FormasArmaduras
    {
        public static RebarGroup CompletaRebar(int colorEstribo, string diametro, string RebarGrade, double separacion,
            Point StartPoint, Point EndPoint, Beam myBeam, Polygon polygon1, Polygon polygon2,
            RebarGroup.RebarGroupSpacingTypeEnum pasoTipo, string espacios1, string recini, string rec1, string recfin,
            string Dini, RebarGroup.ExcludeTypeEnum creacionBar, string nombre, int _Variable)
        {
            // initialize the rebar group object for stirrup creation
            RebarGroup rebarGroup = new RebarGroup();

            //double radioEstribo = 15.0;
            //ValoresStandard.RadioEstribo(diametro, out radioEstribo);
            double radioEstribo = LibreriaOMBIM.ValoresStandard.GetStartHookValues(diametro, RebarGrade, "Radio");


            rebarGroup.Father = myBeam;
            rebarGroup.Size = diametro;
            rebarGroup.RadiusValues.Add(radioEstribo);
            rebarGroup.Grade = RebarGrade;
            rebarGroup.Name = nombre;
            rebarGroup.Class = colorEstribo;
            rebarGroup.EndPointOffsetType = Reinforcement.RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;
            rebarGroup.StartPointOffsetType = Reinforcement.RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;
            rebarGroup.ExcludeType = creacionBar;


            //rebarGroup.StartHook.Length = lPatIni;
            rebarGroup.StartHook.Radius = radioEstribo;
            rebarGroup.StartHook.Shape = RebarHookData.RebarHookShapeEnum.NO_HOOK;
            //rebarGroup.EndHook.Length = lPatFin;
            rebarGroup.EndHook.Radius = radioEstribo;
            rebarGroup.EndHook.Shape = RebarHookData.RebarHookShapeEnum.NO_HOOK;


            DistanceList distanceList2 = new DistanceList();
            ArrayList _RebarRecList = new ArrayList();
            distanceList2 = DistanceList.Parse(rec1, CultureInfo.InvariantCulture, Distance.UnitType.Millimeter);
            foreach (Distance distance2 in distanceList2)
                _RebarRecList.Add(distance2.ConvertTo(Distance.UnitType.Millimeter));

            for (int i = 0; i < _RebarRecList.Count; i++)
            {
                double sepa = double.Parse(_RebarRecList[i].ToString());
                rebarGroup.OnPlaneOffsets.Add(sepa);
            }

            double inicio = double.Parse(recini.ToString());
            double final = double.Parse(recfin.ToString());

           
            rebarGroup.EndPointOffsetValue = final;

            rebarGroup.StartPointOffsetValue = inicio;


            DistanceList distanceList3 = new DistanceList();
            ArrayList _RebarRecList3 = new ArrayList();
            distanceList3 = DistanceList.Parse(Dini, CultureInfo.InvariantCulture, Distance.UnitType.Millimeter);
            foreach (Distance distance2 in distanceList3)
                _RebarRecList3.Add(distance2.ConvertTo(Distance.UnitType.Millimeter));


            double recInicio = 0;
            double recFinal = 0;


            if (_RebarRecList3.Count > 0)
            {
                double sepa = double.Parse(_RebarRecList3[0].ToString());
                rebarGroup.FromPlaneOffset = sepa;
                recInicio = sepa;
                if (_RebarRecList3.Count > 1)
                {
                    double sepa2 = double.Parse(_RebarRecList3[1].ToString());
                    rebarGroup.EndFromPlaneOffset = sepa2;
                    recFinal = sepa2;
                }
                else
                {
                    rebarGroup.EndFromPlaneOffset = sepa;
                    recFinal = sepa;
                }
            }

            if (pasoTipo == BaseRebarGroup.RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACINGS)
            {
                if (espacios1 == "0")
                {

                    double longitud = Tekla.Structures.Geometry3d.Distance.PointToPoint(StartPoint, EndPoint);
                    longitud = longitud - recInicio - recFinal;

                    double cantidad = longitud / separacion;
                    cantidad = Math.Round(cantidad, 0, MidpointRounding.AwayFromZero);
                    espacios1 = cantidad.ToString() + "*" + separacion.ToString();

                }
            }

            DistanceList distanceList = new DistanceList();
            ArrayList _RebarSpacingList = new ArrayList();
            distanceList = DistanceList.Parse(espacios1, CultureInfo.InvariantCulture, Distance.UnitType.Millimeter);
            foreach (Distance distance in distanceList)
                _RebarSpacingList.Add(distance.ConvertTo(Distance.UnitType.Millimeter));



            if (espacios1 != "0")
            {
                for (int i = 0; i < _RebarSpacingList.Count; i++)
                {
                    double sepa = double.Parse(_RebarSpacingList[i].ToString());
                    rebarGroup.Spacings.Add(sepa);
                }
            }
            else
            {
                // set group spacing
                rebarGroup.Spacings.Add(separacion);
            }
            rebarGroup.SpacingType = pasoTipo;

            if (_Variable == 1)
            {
                rebarGroup.Polygons.Add(polygon1);
            }
            else
            {
                rebarGroup.StartPoint = StartPoint;
                rebarGroup.EndPoint = EndPoint;
            }

            rebarGroup.Polygons.Add(polygon2);

            //rebarGroup.Insert();

            return rebarGroup;
        }



        public static void EstriboFormaC(int colorEstribo, string diametro, string RebarGrade, double separacion,
            Point StartPoint, Point EndPoint, Beam myBeam, Polygon polygon1, Polygon polygon2,
            RebarGroup.RebarGroupSpacingTypeEnum pasoTipo, string espacios1, string recini, string rec1, string recfin,
            string Dini, RebarGroup.ExcludeTypeEnum creacionBar, string nombre, string numFila, int _Variable)
        {
            //double radioEstribo = 15.0;
            //ValoresStandard.RadioEstribo(diametro, out radioEstribo);
            double radioEstribo = LibreriaOMBIM.ValoresStandard.GetStartHookValues(diametro, RebarGrade, "Radio");

            RebarGroup rebarGroup = FormasArmaduras.CompletaRebar(colorEstribo, diametro, RebarGrade, separacion,
                StartPoint, EndPoint, myBeam, polygon1, polygon2, pasoTipo, espacios1, recini, rec1, recfin, Dini,
                creacionBar, nombre, _Variable);

            rebarGroup.OnPlaneOffsets.Clear();
            rebarGroup.OnPlaneOffsets.Add(-radioEstribo);


            rebarGroup.StartHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_180_DEGREES;
            rebarGroup.EndHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_180_DEGREES;

            FormasArmaduras.ModificaPrefijoArmadura(rebarGroup, "Estribo");

            rebarGroup.SetUserProperty("comment", numFila);
            string GUID = rebarGroup.Identifier.GUID.ToString();
            rebarGroup.SetUserProperty("USER_FIELD_2", GUID);
           
            
            
            if (!rebarGroup.Insert())
            {
                LoggerHelper.Error("Insert failed in EstriboFormaC");
            }

        }



        public static void EstriboFormaC2(int colorEstribo, string diametro, string RebarGrade, double separacion,
         Point StartPoint, Point EndPoint, Beam myBeam, Polygon polygon1, Polygon polygon2,
         RebarGroup.RebarGroupSpacingTypeEnum pasoTipo, string espacios1, string recini, string rec1, string recfin,
         string Dini, RebarGroup.ExcludeTypeEnum creacionBar, string nombre, string numFila, int _Variable)
        {
            //double radioEstribo = 15.0;
            //ValoresStandard.RadioEstribo(diametro, out radioEstribo);
            double radioEstribo = LibreriaOMBIM.ValoresStandard.GetStartHookValues(diametro, RebarGrade, "Radio");

            double lengthHook = 15.0;
            ValoresStandard.LengthHook(diametro, out lengthHook);


            RebarGroup rebarGroup = FormasArmaduras.CompletaRebar(colorEstribo, diametro, RebarGrade, separacion,
                StartPoint, EndPoint, myBeam, polygon1, polygon2, pasoTipo, espacios1, recini, rec1, recfin, Dini,
                creacionBar, nombre, _Variable);

            //rebarGroup.OnPlaneOffsets.Clear();
            //rebarGroup.OnPlaneOffsets.Add(-radioEstribo);


            rebarGroup.StartHook.Angle = 90;
            rebarGroup.StartHook.Length = lengthHook;
            rebarGroup.StartHook.Radius = radioEstribo;
            rebarGroup.EndHook.Angle = 90;
            rebarGroup.EndHook.Length = lengthHook;
            rebarGroup.EndHook.Radius = radioEstribo;
            rebarGroup.StartHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;
            rebarGroup.EndHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;





            FormasArmaduras.ModificaPrefijoArmadura(rebarGroup, "Estribo");

            rebarGroup.SetUserProperty("comment", numFila);
            string GUID = rebarGroup.Identifier.GUID.ToString();
            rebarGroup.SetUserProperty("USER_FIELD_2", GUID);
            
            
            
            if (!rebarGroup.Insert())
            {
                LoggerHelper.Error("Insert failed in EstriboFormaC2");
            }

        }

        public static RebarGroup EstriboHook135(int colorEstribo, string diametro, string RebarGrade,
          double separacion, Point StartPoint, Point EndPoint, Beam myBeam, Polygon polygon1,
          Polygon polygon2, RebarGroup.RebarGroupSpacingTypeEnum pasoTipo, string espacios1,
          string recini, string rec1, string recfin, string Dini, RebarGroup.ExcludeTypeEnum creacionBar,
          string nombre, string numFila, int _Variable)
        {

            RebarGroup rebarGroup = FormasArmaduras.CompletaRebar(colorEstribo, diametro, RebarGrade, separacion,
                StartPoint, EndPoint, myBeam, polygon1, polygon2, pasoTipo, espacios1, recini, rec1, recfin, Dini,
                creacionBar, nombre, _Variable);


            ////////   esto para poner el recubrimiento inicial y final
            DistanceList distanceList2 = new DistanceList();
            ArrayList _RebarRecList = new ArrayList();
            distanceList2 = DistanceList.Parse(rec1, CultureInfo.InvariantCulture, Distance.UnitType.Millimeter);
            foreach (Distance distance2 in distanceList2)
                _RebarRecList.Add(distance2.ConvertTo(Distance.UnitType.Millimeter));

            

            double inicio = double.Parse(_RebarRecList[_RebarRecList.Count - 1].ToString());
            double final = double.Parse(_RebarRecList[0].ToString());

            rebarGroup.StartPointOffsetValue = inicio;
            rebarGroup.EndPointOffsetValue = final;

            rebarGroup.StartHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_135_DEGREES;
            rebarGroup.EndHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_135_DEGREES;
            FormasArmaduras.ModificaPrefijoArmadura(rebarGroup, "Estribo");


            rebarGroup.SetUserProperty("comment", numFila);
            string GUID = rebarGroup.Identifier.GUID.ToString();
            rebarGroup.SetUserProperty("USER_FIELD_2", GUID);
            
            
            
            if (!rebarGroup.Insert())
            {
                LoggerHelper.Error("Insert failed in EstriboHook135");
            }

            return rebarGroup;

        }

        public static RebarGroup EstriboHook90(int colorEstribo, string diametro, string RebarGrade,
            double separacion, Point StartPoint, Point EndPoint, Beam myBeam, Polygon polygon1,
            Polygon polygon2, RebarGroup.RebarGroupSpacingTypeEnum pasoTipo, string espacios1,
            string recini, string rec1, string recfin, string Dini, RebarGroup.ExcludeTypeEnum creacionBar,
            string nombre, string numFila, int _Variable)
        {

            RebarGroup rebarGroup = FormasArmaduras.CompletaRebar(colorEstribo, diametro, RebarGrade, separacion,
                StartPoint, EndPoint, myBeam, polygon1, polygon2, pasoTipo, espacios1, recini, rec1, recfin, Dini,
                creacionBar, nombre, _Variable);

            ////////   esto para poner el recubrimiento inicial y final
            DistanceList distanceList2 = new DistanceList();
            ArrayList _RebarRecList = new ArrayList();
            distanceList2 = DistanceList.Parse(rec1, CultureInfo.InvariantCulture, Distance.UnitType.Millimeter);
            foreach (Distance distance2 in distanceList2)
                _RebarRecList.Add(distance2.ConvertTo(Distance.UnitType.Millimeter));

           

            double inicio = double.Parse(_RebarRecList[_RebarRecList.Count - 1].ToString());
            double final = double.Parse(_RebarRecList[0].ToString());

            rebarGroup.StartPointOffsetValue = inicio;
            rebarGroup.EndPointOffsetValue = final;
            


            rebarGroup.StartHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_90_DEGREES;
            rebarGroup.EndHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_90_DEGREES;

            FormasArmaduras.ModificaPrefijoArmadura(rebarGroup, "Estribo");


            rebarGroup.SetUserProperty("comment", numFila);
            string GUID = rebarGroup.Identifier.GUID.ToString();
            rebarGroup.SetUserProperty("USER_FIELD_2", GUID);
            
            
            
            
            if (!rebarGroup.Insert())
                Console.WriteLine("Insert failed!");


            return rebarGroup;

        }

        public static RebarGroup EstriboPoligonal90Hook(int colorEstribo, string diametro, string RebarGrade,
          double separacion, Point StartPoint, Point EndPoint, Beam myBeam, Polygon polygon1,
          Polygon polygon2, RebarGroup.RebarGroupSpacingTypeEnum pasoTipo, string espacios1,
          string recini, string rec1, string recfin, string Dini, string PatIni, string PatFin,
          RebarGroup.ExcludeTypeEnum creacionBar, string nombre, string numFila, int _Variable)
        {

            RebarGroup rebarGroup = FormasArmaduras.CompletaRebar(colorEstribo, diametro, RebarGrade, separacion,
                StartPoint, EndPoint, myBeam, polygon1, polygon2, pasoTipo, espacios1, recini, rec1, recfin, Dini,
                creacionBar, nombre, _Variable);

            ////////   esto para poner el recubrimiento inicial y final
            DistanceList distanceList2 = new DistanceList();
            ArrayList _RebarRecList = new ArrayList();
            distanceList2 = DistanceList.Parse(rec1, CultureInfo.InvariantCulture, Distance.UnitType.Millimeter);
            foreach (Distance distance2 in distanceList2)
                _RebarRecList.Add(distance2.ConvertTo(Distance.UnitType.Millimeter));

            

            double inicio = double.Parse(recini.ToString());
            double final = double.Parse(recfin.ToString());


            inicio = double.Parse(_RebarRecList[_RebarRecList.Count - 1].ToString());

            if (_RebarRecList.Count > 1)
                final = double.Parse(_RebarRecList[1].ToString());
            else
                final = double.Parse(_RebarRecList[0].ToString());


            rebarGroup.EndPointOffsetValue = final;

            rebarGroup.StartPointOffsetValue = inicio;

            rebarGroup.StartHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_90_DEGREES;
            rebarGroup.EndHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_90_DEGREES;

            FormasArmaduras.ModificaPrefijoArmadura(rebarGroup, "Estribo");


            rebarGroup.SetUserProperty("comment", numFila);
            string GUID = rebarGroup.Identifier.GUID.ToString();
            rebarGroup.SetUserProperty("USER_FIELD_2", GUID);
            
            
            
            if (!rebarGroup.Insert())
                Console.WriteLine("Insert failed!");


            return rebarGroup;

        }

       
        
        public static RebarGroup EstriboPoligonal180Hook(int colorEstribo, string diametro, string RebarGrade,
       double separacion, Point StartPoint, Point EndPoint, Beam myBeam, Polygon polygon1,
       Polygon polygon2, RebarGroup.RebarGroupSpacingTypeEnum pasoTipo, string espacios1,
       string recini, string rec1, string recfin, string Dini, RebarGroup.ExcludeTypeEnum creacionBar, string nombre, string numFila, int _Variable)
        {

            RebarGroup rebarGroup = FormasArmaduras.CompletaRebar(colorEstribo, diametro, RebarGrade, separacion,
                StartPoint, EndPoint, myBeam, polygon1, polygon2, pasoTipo, espacios1, recini, rec1, recfin, Dini,
                creacionBar, nombre, _Variable);

            ////////   esto para poner el recubrimiento inicial y final
            DistanceList distanceList2 = new DistanceList();
            ArrayList _RebarRecList = new ArrayList();
            distanceList2 = DistanceList.Parse(rec1, CultureInfo.InvariantCulture, Distance.UnitType.Millimeter);
            foreach (Distance distance2 in distanceList2)
                _RebarRecList.Add(distance2.ConvertTo(Distance.UnitType.Millimeter));



            double inicio = double.Parse(recini.ToString());
            double final = double.Parse(recfin.ToString());


            inicio = double.Parse(_RebarRecList[_RebarRecList.Count - 1].ToString());

            if (_RebarRecList.Count > 1)
                final = double.Parse(_RebarRecList[1].ToString());
            else
                final = double.Parse(_RebarRecList[0].ToString());


            rebarGroup.EndPointOffsetValue = final;

            rebarGroup.StartPointOffsetValue = inicio;

            rebarGroup.StartHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_180_DEGREES;
            rebarGroup.EndHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_180_DEGREES;

            FormasArmaduras.ModificaPrefijoArmadura(rebarGroup, "Estribo");


            rebarGroup.SetUserProperty("comment", numFila);
            string GUID = rebarGroup.Identifier.GUID.ToString();
            rebarGroup.SetUserProperty("USER_FIELD_2", GUID);



            if (!rebarGroup.Insert())
                Console.WriteLine("Insert failed!");


            return rebarGroup;

        }




        public static RebarGroup EstriboPoligonal(int colorEstribo, string diametro, string RebarGrade,
           double separacion, Point StartPoint, Point EndPoint, Beam myBeam, Polygon polygon1,
           Polygon polygon2, RebarGroup.RebarGroupSpacingTypeEnum pasoTipo, string espacios1,
           string recini, string rec1, string recfin, string Dini, string PatIni, string PatFin,
           RebarGroup.ExcludeTypeEnum creacionBar, string nombre, string numFila, int _Variable)
        {

            RebarGroup rebarGroup = FormasArmaduras.CompletaRebar(colorEstribo, diametro, RebarGrade, separacion,
                StartPoint, EndPoint, myBeam, polygon1, polygon2, pasoTipo, espacios1, recini, rec1, recfin, Dini,
                creacionBar, nombre, _Variable);


            double radioEstribo = ValoresStandard.GetStartHookValues(diametro, RebarGrade, "Radio");

            double lPatIni = double.Parse(PatIni.ToString());
            double lPatFin = double.Parse(PatFin.ToString());


            rebarGroup.StartHook.Angle = 90.0;

            if (lPatIni < 0)
            {
                rebarGroup.StartHook.Angle = -90.0;
            }

            rebarGroup.EndHook.Angle = 90.0;

            if (lPatFin < 0)
            {
                rebarGroup.EndHook.Angle = -90.0;
            }

            rebarGroup.StartHook.Length = Math.Abs(lPatIni);
            rebarGroup.EndHook.Length = Math.Abs(lPatFin);

            rebarGroup.StartHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;
            rebarGroup.EndHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;
           
            rebarGroup.StartHook.Radius = radioEstribo;
            rebarGroup.EndHook.Radius = radioEstribo;

            FormasArmaduras.ModificaPrefijoArmadura(rebarGroup, "Estribo");


            rebarGroup.SetUserProperty("comment", numFila);
            string GUID = rebarGroup.Identifier.GUID.ToString();
            rebarGroup.SetUserProperty("USER_FIELD_2", GUID);
            
            
            
            if (!rebarGroup.Insert())
                Console.WriteLine("Insert failed!");


            return rebarGroup;

        }

        public static RebarGroup EstriboPoligonal90CustomLengthHook(int colorEstribo, string diametro, string RebarGrade,
          double separacion, Point StartPoint, Point EndPoint, Beam myBeam, Polygon polygon1,
          Polygon polygon2, RebarGroup.RebarGroupSpacingTypeEnum pasoTipo, string espacios1,
          string recini, string rec1, string recfin, string Dini, string PatIni, string PatFin,
          RebarGroup.ExcludeTypeEnum creacionBar, string nombre, string numFila, int _Variable)
        {

            RebarGroup rebarGroup = FormasArmaduras.CompletaRebar(colorEstribo, diametro, RebarGrade, separacion,
                StartPoint, EndPoint, myBeam, polygon1, polygon2, pasoTipo, espacios1, recini, rec1, recfin, Dini,
                creacionBar, nombre, _Variable);


            double radioEstribo = ValoresStandard.GetStartHookValues(diametro, RebarGrade, "Radio");


            double lPatIni = double.Parse(PatIni.ToString());
            double lPatFin = double.Parse(PatFin.ToString());


            rebarGroup.StartHook.Angle = 90.0;

            if (lPatIni < 0)
            {
                rebarGroup.StartHook.Angle = -90.0;
            }

            rebarGroup.EndHook.Angle = 90.0;

            if (lPatFin < 0)
            {
                rebarGroup.EndHook.Angle = -90.0;
            }

            rebarGroup.StartHook.Length = Math.Abs(lPatIni);
            rebarGroup.EndHook.Length = Math.Abs(lPatFin);

            rebarGroup.StartHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;
            rebarGroup.EndHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;
            rebarGroup.StartHook.Radius = radioEstribo;
            rebarGroup.EndHook.Radius = radioEstribo;


            FormasArmaduras.ModificaPrefijoArmadura(rebarGroup, "Estribo");


            rebarGroup.SetUserProperty("comment", numFila);
            string GUID = rebarGroup.Identifier.GUID.ToString();
            rebarGroup.SetUserProperty("USER_FIELD_2", GUID);
            
            
            
            if (!rebarGroup.Insert())
                Console.WriteLine("Insert failed!");


            return rebarGroup;

        }


        public static RebarGroup EstriboPoligonalNoHooks(int colorEstribo, string diametro, string RebarGrade,
         double separacion, Point StartPoint, Point EndPoint, Beam myBeam, Polygon polygon1,
         Polygon polygon2, RebarGroup.RebarGroupSpacingTypeEnum pasoTipo, string espacios1,
         string recini, string rec1, string recfin, string Dini, 
         RebarGroup.ExcludeTypeEnum creacionBar, string nombre, string numFila, int _Variable)
        {

            RebarGroup rebarGroup = FormasArmaduras.CompletaRebar(colorEstribo, diametro, RebarGrade, separacion,
                StartPoint, EndPoint, myBeam, polygon1, polygon2, pasoTipo, espacios1, recini, rec1, recfin, Dini,
                creacionBar, nombre, _Variable);

           
            rebarGroup.StartHook.Shape = RebarHookData.RebarHookShapeEnum.NO_HOOK;
            rebarGroup.EndHook.Shape = RebarHookData.RebarHookShapeEnum.NO_HOOK;

            FormasArmaduras.ModificaPrefijoArmadura(rebarGroup, "Estribo");


            rebarGroup.SetUserProperty("comment", numFila);
            string GUID = rebarGroup.Identifier.GUID.ToString();
            rebarGroup.SetUserProperty("USER_FIELD_2", GUID);
            
            
            
            if (!rebarGroup.Insert())
                Console.WriteLine("Insert failed!");


            return rebarGroup;

        }



        public static RebarGroup BarraRefuerzo(int colorEstribo, string diametro, string RebarGrade, double separacion,
            Point StartPoint, Point EndPoint, Beam myBeam, Polygon polygon1, Polygon polygon2,
            RebarGroup.RebarGroupSpacingTypeEnum pasoTipo, string espacios1, string recini, string rec1, string recfin,
            string Dini, string PatIni, string PatFin, RebarGroup.ExcludeTypeEnum creacionBar, string nombre, string numFila, int _Variable)
        {
            double lDini = double.Parse(Dini.ToString());
            double lPatIni = double.Parse(PatIni.ToString());
            double lPatFin = double.Parse(PatFin.ToString());

            //double radioEstribo = 15.0;
            //ValoresStandard.RadioEstribo(diametro, out radioEstribo);
            double radioEstribo = LibreriaOMBIM.ValoresStandard.GetStartHookValues(diametro, RebarGrade, "Radio");

            RebarGroup rebarGroup = FormasArmaduras.CompletaRebar(colorEstribo, diametro, RebarGrade, separacion, StartPoint, EndPoint, myBeam, polygon1, polygon2, pasoTipo, espacios1, recini, rec1, recfin, Dini, creacionBar, nombre, _Variable);

            rebarGroup.StartHook.Angle = 90.0;

            if (lPatIni < 0)
            {
                rebarGroup.StartHook.Angle = -90.0;
            }

            rebarGroup.EndHook.Angle = 90.0;

            if (lPatFin < 0)
            {
                rebarGroup.EndHook.Angle = -90.0;
            }


            rebarGroup.StartHook.Length = Math.Abs(lPatIni);
            rebarGroup.StartHook.Radius = radioEstribo;

            rebarGroup.EndHook.Length = Math.Abs(lPatFin);
            rebarGroup.EndHook.Radius = radioEstribo;

            rebarGroup.StartHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;
            rebarGroup.EndHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;

            FormasArmaduras.ModificaPrefijoArmadura(rebarGroup, "Refuerzo");

            rebarGroup.SetUserProperty("comment", numFila);
            string GUID = rebarGroup.Identifier.GUID.ToString();
            rebarGroup.SetUserProperty("USER_FIELD_2", GUID);
            
            
            
            if (!rebarGroup.Insert())
                Console.WriteLine("Insert failed!");

            return rebarGroup;
        }

        public static RebarGroup CreaGrupoEstriboe5(int colorEstribo, string diametro, string rebarGrade, Point StartPoint, Point EndPoint,
            Beam myBeam, Polygon polygon1, BaseRebarGroup.RebarGroupSpacingTypeEnum pasoTipo,
            string espacios1, string recini, string rec1, string recfin, string Dini,
            string PatIni, string PatFin, BaseRebarGroup.ExcludeTypeEnum creacionBar,string nombre,
            string numFila, bool Alreves)
        {
            //radioEstribo = RadioEstribo(diametro);
            //double radioEstribo = 15.0;
            //LibraryControlClass.ValoresStandard.RadioEstribo(diametro, out radioEstribo);
            //if (IsDefaultValue(_RadioAP))
                
            double radioEstribo = LibreriaOMBIM.ValoresStandard.GetStartHookValues(diametro, rebarGrade, "Radio");


            double lDini = double.Parse(Dini.ToString());
            double lPatIni = double.Parse(PatIni.ToString());
            double lPatFin = double.Parse(PatFin.ToString());

            // initialize the rebar group object for stirrup creation
            RebarGroup rebarGroup = new RebarGroup();
            rebarGroup.Father = myBeam;
            rebarGroup.Size = diametro;
            rebarGroup.RadiusValues.Add(radioEstribo);
            rebarGroup.Grade = rebarGrade;

            rebarGroup.FromPlaneOffset = lDini;
            rebarGroup.Name = nombre;
            rebarGroup.Class = colorEstribo;
            rebarGroup.EndPointOffsetType = Reinforcement.RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;
            rebarGroup.StartPointOffsetType = Reinforcement.RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;

            double angle = 90.0;
            if (Alreves)
                angle *= -1;

            rebarGroup.StartHook.Angle = angle;
            rebarGroup.EndHook.Angle = angle;



            if (lPatIni < 0)
            {
                rebarGroup.StartHook.Angle *= -1;
            }

            if (lPatFin < 0)
            {
                rebarGroup.EndHook.Angle *= -1;
            }

            rebarGroup.StartHook.Length = Math.Abs(lPatIni);
            rebarGroup.StartHook.Radius = radioEstribo;

            rebarGroup.EndHook.Length = Math.Abs(lPatFin);
            rebarGroup.EndHook.Radius = radioEstribo;

            rebarGroup.StartHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;

            rebarGroup.EndHook.Shape = RebarHookData.RebarHookShapeEnum.CUSTOM_HOOK;
            rebarGroup.ExcludeType = creacionBar;


            DistanceList distanceList2 = new DistanceList();
            ArrayList _RebarRecList = new ArrayList();
            distanceList2 = DistanceList.Parse(rec1, CultureInfo.InvariantCulture, Distance.UnitType.Millimeter);
            foreach (Distance distance2 in distanceList2)
                _RebarRecList.Add(distance2.ConvertTo(Distance.UnitType.Millimeter));

            double inicio = double.Parse(recini.ToString());
            double final = double.Parse(recfin.ToString());

            rebarGroup.StartPointOffsetValue = inicio;
            rebarGroup.EndPointOffsetValue = final;

            for (int i = 0; i < _RebarRecList.Count; i++)
            {
                double recub = double.Parse(_RebarRecList[i].ToString());

                if (Alreves)
                    recub *= -1;

                rebarGroup.OnPlaneOffsets.Add(recub);
            }


            DistanceList distanceList = new DistanceList();
            ArrayList _RebarSpacingList = new ArrayList();
            distanceList = DistanceList.Parse(espacios1, CultureInfo.InvariantCulture, Distance.UnitType.Millimeter);

            foreach (Distance distance in distanceList)
                _RebarSpacingList.Add(distance.ConvertTo(Distance.UnitType.Millimeter));


            rebarGroup.SpacingType = pasoTipo;

            rebarGroup.Spacings = _RebarSpacingList;


            rebarGroup.StartPoint = StartPoint;
            rebarGroup.EndPoint = EndPoint;


            rebarGroup.Polygons.Add(polygon1);



            rebarGroup.SetUserProperty("comment", numFila);

            string GUID = rebarGroup.Identifier.GUID.ToString();
            rebarGroup.SetUserProperty("USER_FIELD_2", GUID);


            FormasArmaduras.ModificaPrefijoArmadura(rebarGroup, "Refuerzo");
            if (!rebarGroup.Insert())
                Console.WriteLine("Insert failed!");

            return rebarGroup;
        }



        public static RebarGroup BarraRecta(int colorEstribo, string diametro, string RebarGrade, double separacion,
            Point StartPoint, Point EndPoint, Beam myBeam, Polygon polygon1, Polygon polygon2,
            RebarGroup.RebarGroupSpacingTypeEnum pasoTipo, string espacios1, string recini, string rec1, string recfin, string Dini,
            string PatIni, string PatFin, RebarGroup.ExcludeTypeEnum creacionBar, string nombre, string numFila, int _Variable)
        {
            double lPatIni = double.Parse(PatIni.ToString());
            double lPatFin = double.Parse(PatFin.ToString());

            //double radioEstribo = 15.0;
            //ValoresStandard.RadioEstribo(diametro, out radioEstribo);
            double radioEstribo = LibreriaOMBIM.ValoresStandard.GetStartHookValues(diametro, RebarGrade, "Radio");

            double actualDiametro = LibreriaOMBIM.ValoresStandard.CompruebaDiametroNominalReal(diametro, RebarGrade);

            if (lPatIni != 0)
                lPatIni = lPatIni - radioEstribo - actualDiametro;
            if (lPatFin != 0)
                lPatFin = lPatFin - radioEstribo - actualDiametro;

            RebarGroup rebarGroup = FormasArmaduras.CompletaRebar(colorEstribo, diametro, RebarGrade, separacion, StartPoint, EndPoint, myBeam, polygon1, polygon2, pasoTipo, espacios1, recini, rec1, recfin, Dini, creacionBar, nombre, _Variable);


            rebarGroup.StartHook.Angle = -90.0;

            if (lPatIni < 0)
            {
                rebarGroup.StartHook.Angle = 90.0;
            }

            rebarGroup.EndHook.Angle = -90.0;

            if (lPatFin < 0)
            {
                rebarGroup.EndHook.Angle = 90.0;
            }

            rebarGroup.StartHook.Length = Math.Abs(lPatIni);
            rebarGroup.StartHook.Radius = radioEstribo;

            rebarGroup.EndHook.Length = Math.Abs(lPatFin);
            rebarGroup.EndHook.Radius = radioEstribo;



            rebarGroup.SetUserProperty("comment", numFila);
            string GUID = rebarGroup.Identifier.GUID.ToString();
            rebarGroup.SetUserProperty("USER_FIELD_2", GUID);


            FormasArmaduras.ModificaPrefijoArmadura(rebarGroup, "Barra");
            if (!rebarGroup.Insert())
                Console.WriteLine("Insert failed!");

            return rebarGroup;

        }




        public static void ModificaPrefijoArmadura(RebarGroup rebarGroup, string TipoEstribo)
        {
            if (TipoEstribo == "Barra")
            {
                rebarGroup.NumberingSeries.Prefix = "R";
                rebarGroup.NumberingSeries.StartNumber = 1;
            }
            else if (TipoEstribo == "Estribo")
            {
                rebarGroup.NumberingSeries.Prefix = "R";
                rebarGroup.NumberingSeries.StartNumber = 1;
            }else if (TipoEstribo == "BarraZ")
            {
                rebarGroup.NumberingSeries.Prefix = "R";
                rebarGroup.NumberingSeries.StartNumber = 1;
            }
            else if (TipoEstribo == "EstriboZ")
            {
                rebarGroup.NumberingSeries.Prefix = "R";
                rebarGroup.NumberingSeries.StartNumber = 1;
            }
            else if (TipoEstribo == "Refuerzo")
            {
                rebarGroup.NumberingSeries.Prefix = "R";
                rebarGroup.NumberingSeries.StartNumber = 1;
            }


            //rebarGroup.Modify();

        }

        public static void ModificaPrefijoArmadura(SingleRebar stirrup, string TipoEstribo)
        {
            if (TipoEstribo == "Barra")
            {
                stirrup.NumberingSeries.Prefix = "R";
                stirrup.NumberingSeries.StartNumber = 1;
            }
            else if (TipoEstribo == "Estribo")
            {
                stirrup.NumberingSeries.Prefix = "R";
                stirrup.NumberingSeries.StartNumber = 1;
            }
            else if (TipoEstribo == "BarraZ")
            {
                stirrup.NumberingSeries.Prefix = "R";
                stirrup.NumberingSeries.StartNumber = 1;
            }
            else if (TipoEstribo == "EstriboZ")
            {
                stirrup.NumberingSeries.Prefix = "R";
                stirrup.NumberingSeries.StartNumber = 1;
            }
            else if (TipoEstribo == "Refuerzo")
            {
                stirrup.NumberingSeries.Prefix = "R";
                stirrup.NumberingSeries.StartNumber = 1;
            }


            //stirrup.Modify();

        }

    }
}
