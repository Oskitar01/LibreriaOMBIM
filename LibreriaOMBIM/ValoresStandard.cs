using System;
using System.Globalization;
using Tekla.Structures;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace LibreriaOMBIM
{
    public sealed class ValoresStandard
    {
        public static double CompruebaDiametroNominalReal(string diametro, string rebarGrade)
        {
            double actualDiametro = double.Parse(diametro.ToString());
            bool IsNominalDiameter = false;

            TeklaStructuresSettings.GetAdvancedOption("XS_USE_ONLY_NOMINAL_REBAR_DIAMETER", ref IsNominalDiameter);

            //double actualDiametro = double.Parse(diametro);
            if (!IsNominalDiameter)
            {
                actualDiametro = DiaNominalToActualDiametro(diametro, rebarGrade);

            }

            return actualDiametro;
        }
        private static double DiaNominalToActualDiametro(string dia, string grade)
        {
            //dia = "6";
            //grade = "B500S";
            double actual = 0;
            Tekla.Structures.Catalogs.CatalogHandler CatalogHandler = new Tekla.Structures.Catalogs.CatalogHandler();

            Tekla.Structures.Catalogs.RebarItemEnumerator rebarsItems = CatalogHandler.GetRebarItems();
            while (rebarsItems.MoveNext())
            {
                Tekla.Structures.Catalogs.RebarItem Item = rebarsItems.Current;
                if (Item.Grade.Equals(grade.ToString()))
                    if (Item.Size.Equals(dia.ToString()))
                        actual = Item.ActualDiameter;
            }

            return actual;
        }

        public static double GetStartHookValues(string dia, string grade, string rebarsItem)
        {
            //dia = "6";
            //grade = "B500S";
            double actual = 0;
            Tekla.Structures.Catalogs.CatalogHandler CatalogHandler = new Tekla.Structures.Catalogs.CatalogHandler();

            Tekla.Structures.Catalogs.RebarItemEnumerator rebarsItems = CatalogHandler.GetRebarItems();
            while (rebarsItems.MoveNext())
            {
                Tekla.Structures.Catalogs.RebarItem Item =  rebarsItems.Current;
                if (Item.Grade.Equals(grade.ToString()))
                    if (Item.Size.Equals(dia.ToString()))
                    {
                       if(rebarsItem=="Longitud90")
                            actual = Item.HookLength90Degrees;
                        if (rebarsItem == "Longitud135")
                            actual = Item.HookLength135Degrees;
                        if (rebarsItem == "Longitud180")
                            actual = Item.HookLength180Degrees;
                        if (rebarsItem == "RadioHook")
                            actual = Item.HookRadius90Degrees;
                        if (rebarsItem == "Radio")
                            actual = Item.BendRadius;
                    }
                        
            }

            return actual;
        }
        public static int diametrosNominalToActual(int diametroNominal)
        {
            int diametroActual = 15;

            if (diametroNominal == 6) { diametroActual = 8; }
            else if (diametroNominal == 8) { diametroActual = 10; }
            else if (diametroNominal == 10) { diametroActual = 12; }
            else if (diametroNominal == 12) { diametroActual = 14; }
            else if (diametroNominal == 16) { diametroActual = 18; }
            else if (diametroNominal == 20) { diametroActual = 23; }
            else if (diametroNominal == 25) { diametroActual = 29; }
            else if (diametroNominal == 32) { diametroActual = 36; }
            else if (diametroNominal == 40) { diametroActual = 45; }
            else if (diametroNominal == 43) { diametroActual = 49; }
            else if (diametroNominal == 50) { diametroActual = 57; }
            else if (diametroNominal == 57) { diametroActual = 65; }



            return diametroActual;
        }


        public static void DuplicaBarraDummy(Part modelObject)
        {
            var vectorOrigen9 = new Vector(0, 1, 0);
            vectorOrigen9.Normalize(0);
            Part barra = Tekla.Structures.Model.Operations.Operation.CopyObject(modelObject, vectorOrigen9) as Part;




            double diametroNominal = 0;
            barra.GetReportProperty("WIDTH", ref diametroNominal);
            diametroNominal = Math.Round(diametroNominal, 0);

            int diametroActual = 15;

            if (diametroNominal == 6) { diametroActual = 8; }
            else if (diametroNominal == 8) { diametroActual = 10; }
            else if (diametroNominal == 10) { diametroActual = 12; }
            else if (diametroNominal == 12) { diametroActual = 14; }
            else if (diametroNominal == 16) { diametroActual = 18; }
            else if (diametroNominal == 20) { diametroActual = 23; }
            else if (diametroNominal == 25) { diametroActual = 29; }
            else if (diametroNominal == 32) { diametroActual = 36; }
            else if (diametroNominal == 40) { diametroActual = 45; }
            else if (diametroNominal == 43) { diametroActual = 49; }
            else if (diametroNominal == 50) { diametroActual = 57; }
            else if (diametroNominal == 57) { diametroActual = 65; }

            barra.Profile.ProfileString = "D" + diametroActual;
            barra.Name = "DUMMY";
            barra.Material.MaterialString = "DUMMY";
            barra.Modify();
        }

        public static double RadioEstribo(string diametro, out double radioEstribo)
        {
            radioEstribo = 15.0;

            if (diametro == "6") { radioEstribo = 15.0; }
            else if (diametro == "8") { radioEstribo = 15.0; }
            else if (diametro == "10") { radioEstribo = 15.0; }
            else if (diametro == "12") { radioEstribo = 18.0; }
            else if (diametro == "16") { radioEstribo = 32.0; }
            else if (diametro == "20") { radioEstribo = 70.0; }
            else if (diametro == "25") { radioEstribo = 87.5; }
            else if (diametro == "32") { radioEstribo = 112.0; }
            else if (diametro == "40") { radioEstribo = 140.0; }
            else if (diametro == "43") { radioEstribo = 150.5; }
            else if (diametro == "50") { radioEstribo = 175.0; }
            else if (diametro == "57") { radioEstribo = 199.5; }



            return radioEstribo;
        }

        public static double LengthHook(string diametro, out double lengthHook)
        {
            lengthHook = 15.0;

            if (diametro == "6") { lengthHook = 45.0; }
            else if (diametro == "8") { lengthHook = 60.0; }
            else if (diametro == "10") { lengthHook = 75.0; }
            else if (diametro == "12") { lengthHook = 90.0; }
            else if (diametro == "16") { lengthHook = 120.0; }
            else if (diametro == "20") { lengthHook = 150.0; }
            else if (diametro == "25") { lengthHook = 188.0; }
            else if (diametro == "32") { lengthHook = 240.0; }
            else if (diametro == "40") { lengthHook = 240.0; }
            else if (diametro == "43") { lengthHook = 240.0; }
            else if (diametro == "50") { lengthHook = 240.0; }
            else if (diametro == "57") { lengthHook = 240.0; }



            return lengthHook;
        }

        public static void defaultValueTaladro(int diametro, out double taladro)
        {
            taladro = 0;
            if (diametro == 6)
            {
                taladro = 8;
            }
            if (diametro == 8)
            {
                taladro = 10;
            }
            if (diametro == 10)
            {
                taladro = 12;
            }
            if (diametro == 12)
            {
                taladro = 15;
            }
            if (diametro == 14)
            {
                taladro = 18;
            }
            if (diametro == 16)
            {
                taladro = 21;
            }
            else if (diametro == 20)
            {
                taladro = 26;
            }
            else if (diametro == 25)
            {
                taladro = 32;
            }
            else if (diametro == 32)
            {
                taladro = 40;
            }
            else if (diametro == 40)
            {
                taladro = 50;
            }
            else if (diametro == 43)
            {
                taladro = 55;
            }
            else if (diametro == 50)
            {
                taladro = 60;
            }
            else if (diametro == 57)
            {
                taladro = 70;
            }
        }

        public static void defaultValueAranTuGrower(double metRoscada, out double altAran, out double altGrower, out double altTuerca)
        {
            altAran = 0;
            altGrower = 0;
            altTuerca = 0;
            if (metRoscada == 6)
            {
                altAran = 1.6;
                altGrower = 1.6;
                altTuerca = 5.0;
            }
            else if (metRoscada == 8)
            {
                altAran = 1.6;
                altGrower = 2.0;
                altTuerca = 6.5;
            }
            else if (metRoscada == 10)
            {
                altAran = 2.0;
                altGrower = 2.2;
                altTuerca = 8.0;
            }
            else if (metRoscada == 12)
            {
                altAran = 2.5;
                altGrower = 2.5;
                altTuerca = 10.0;
            }
            else if (metRoscada == 14)
            {
                altAran = 2.5;
                altGrower = 2.5;
                altTuerca = 11.5;
            }
            else if (metRoscada == 16)
            {
                altAran = 3;
                altGrower = 3.5;
                altTuerca = 13.0;
            }
            else if (metRoscada == 20)
            {
                altAran = 3.0;
                altGrower = 4.0;
                altTuerca = 16.0;
            }
            else if (metRoscada == 24)
            {
                altAran = 4.0;
                altGrower = 5.0;
                altTuerca = 19.0;
            }
            else if (metRoscada == 27)
            {
                altAran = 4.0;
                altGrower = 5.5;
                altTuerca = 22.0;
            }
            else if (metRoscada == 30)
            {
                altAran = 4.0;
                altGrower = 6.0;
                altTuerca = 24.0;
            }
            else if (metRoscada == 36)
            {
                altAran = 5.0;
                altGrower = 6.0;
                altTuerca = 29.0;
            }
            else if (metRoscada == 39)
            {
                altAran = 6.0;
                altGrower = 6.0;
                altTuerca = 31.0;
            }
            else if (metRoscada == 42)
            {
                altAran = 7.0;
                altGrower = 7.0;
                altTuerca = 34.0;
            }
            else if (metRoscada == 45)
            {
                altAran = 7.0;
                altGrower = 7.0;
                altTuerca = 36.0;
            }
            else if (metRoscada == 48)
            {
                altAran = 7.0;
                altGrower = 7.0;
                altTuerca = 38.0;
            }
            else if (metRoscada == 52)
            {
                altAran = 8.0;
                altGrower = 8.0;
                altTuerca = 42.0;
            }
            else if (metRoscada == 56)
            {
                altAran = 9.0;
                altGrower = 8.0;
                altTuerca = 45.0;
            }
            else if (metRoscada == 64)
            {
                altAran = 9.0;
                altGrower = 8.0;
                altTuerca = 51.0;
            }
        }

        public static void CrearVacioTaladroConAvellanadoDireccionZ(int diametroBarra, double posicionX, Part chapa, double posicionY, double posicionZ, double espesorChapa, bool invertirDireccion)
        {
            double LongitudSoldaduraGrande = 0.4 * diametroBarra / Math.Sin(45 * Math.PI / 180);
            LongitudSoldaduraGrande = Math.Round(LongitudSoldaduraGrande, 2);


            double grande = (LongitudSoldaduraGrande * 2) + diametroBarra;
            double diametroTaladro = 0.0;

            defaultValueTaladro(diametroBarra, out diametroTaladro);

            string DiametroSolGrande = ConvertComaToDot(grande);


            string diametro1 = "d" + DiametroSolGrande + "*" + DiametroSolGrande + "*" + diametroBarra + "*" + diametroBarra;
            string diametro2 = "d" + diametroTaladro;


            double posicionZ1 = posicionZ + LongitudSoldaduraGrande;
            double posicionZ2 = posicionZ + espesorChapa;

            if (invertirDireccion)
            {
                posicionZ1 = posicionZ - LongitudSoldaduraGrande;
                posicionZ2 = posicionZ - espesorChapa;
            }

            Beam g3 = CreateRebajeSoldaduras(new Point(posicionX, posicionY, posicionZ), new Point(posicionX, posicionY, posicionZ1), diametro1);
            Beam g4 = CreateRebajeSoldaduras(new Point(posicionX, posicionY, posicionZ), new Point(posicionX, posicionY, posicionZ2), diametro2);
            BooleanPartAdd(g3, g4);
            BoolNegativo(chapa, g3);
            //BoolNegativo(chapa, g4);

            g3.Delete();
        }


        public static void CrearVacioTaladroConAvellanado(int diametroBarra, Point origen, Part chapa, double DistY, double posicionZ, double espesorChapa, bool invertirDireccion)
        {
            double LongitudSoldaduraGrande = 0.4 * diametroBarra / Math.Sin(45 * Math.PI / 180);
            LongitudSoldaduraGrande = Math.Round(LongitudSoldaduraGrande, 2);


            double grande = (LongitudSoldaduraGrande * 2) + diametroBarra;
            double diametroTaladro = 0.0;

            defaultValueTaladro(diametroBarra, out diametroTaladro);

            string DiametroSolGrande = ConvertComaToDot(grande);


            string diametro1 = "d" + DiametroSolGrande + "*" + DiametroSolGrande + "*" + diametroTaladro + "*" + diametroTaladro;
            string diametro2 = "d" + diametroTaladro;


            double posicionX1 = origen.X + LongitudSoldaduraGrande;
            double posicionX2 = origen.X + espesorChapa;

            if (invertirDireccion)
            {
                posicionX1 = origen.X - LongitudSoldaduraGrande;
                posicionX2 = origen.X - espesorChapa;
            }

            Beam g3 = CreateRebajeSoldaduras(new Point(origen.X, DistY, posicionZ), new Point(posicionX1, DistY, posicionZ), diametro1);
            Beam g4 = CreateRebajeSoldaduras(new Point(origen.X, DistY, posicionZ), new Point(posicionX2, DistY, posicionZ), diametro2);
            BooleanPartAdd(g3, g4);
            BoolNegativo(chapa, g3);

            g3.Delete();
        }

        public static Beam CrearRellenoTaladroConAvellanado(int diametroBarra, Point origen, double DistY, double posicionZ, double espesorChapa, bool invertirDireccion)
        {
            double LongitudSoldaduraGrande = 0.4 * diametroBarra / Math.Sin(45 * Math.PI / 180);
            LongitudSoldaduraGrande = Math.Round(LongitudSoldaduraGrande, 2);


            double grande = (LongitudSoldaduraGrande * 2) + diametroBarra;
            double diametroTaladro = 0.0;

            defaultValueTaladro(diametroBarra, out diametroTaladro);

            string DiametroSolGrande = ConvertComaToDot(grande);


            string diametro = "d" + diametroBarra;
            string diametro1 = "d" + DiametroSolGrande + "*" + DiametroSolGrande + "*" + diametroTaladro + "*" + diametroTaladro;
            string diametro2 = "d" + diametroTaladro;


            double posicionX1 = origen.X + LongitudSoldaduraGrande;
            double posicionX2 = origen.X + espesorChapa;

            if (invertirDireccion)
            {
                posicionX1 = origen.X - LongitudSoldaduraGrande;
                posicionX2 = origen.X - espesorChapa;
            }

            Beam g3 = CreateSoldaduras(new Point(origen.X, DistY, posicionZ), new Point(posicionX1, DistY, posicionZ), diametro1);
            Beam g4 = CreateSoldaduras(new Point(origen.X, DistY, posicionZ), new Point(posicionX2, DistY, posicionZ), diametro2);
            BooleanPartAdd(g3, g4);


            Beam g5 = CreateRebajeSoldaduras(new Point(origen.X, DistY, posicionZ), new Point(posicionX2, DistY, posicionZ), diametro);
            BoolNegativo(g3, g5);
            g5.Delete();


            return g3;
        }


        private static NumberFormatInfo MyFormat = null;

        private static string ConvertComaToDot(double numberComa)
        {
            CultureInfo MyCulture = CultureInfo.InstalledUICulture;
            MyFormat = (NumberFormatInfo)MyCulture.NumberFormat.Clone();
            MyFormat.NumberDecimalSeparator = ".";
            string numberComaD = System.String.Format(MyFormat, "{0:0.00}", numberComa); // This gives 3000.00


            return numberComaD;
        }

        private static Beam CreateRebajeSoldaduras(Point p1, Point p2, string perfil)
        {
            Beam myBeam = new Beam(new Point(p1),
                                    new Point(p2));
            myBeam.Name = "SOLDADURA";
            myBeam.Material.MaterialString = "Misc_Undefined";
            myBeam.Profile.ProfileString = perfil;
            myBeam.Position.Rotation = Position.RotationEnum.TOP;
            myBeam.Position.Plane = Position.PlaneEnum.MIDDLE;
            myBeam.Position.Depth = Position.DepthEnum.MIDDLE;

            myBeam.Class = BooleanPart.BooleanOperativeClassName;
            myBeam.Insert();


            return myBeam;
        }

        private static BooleanPart BooleanPartAdd(Part beam, Part addPart)
        {
            addPart.Class = BooleanPart.BooleanOperativeClassName;

            BooleanPart boolPart = new BooleanPart();

            boolPart.Type = BooleanPart.BooleanTypeEnum.BOOLEAN_ADD;
            boolPart.Father = beam;
            boolPart.SetOperativePart(addPart);
            boolPart.Insert();


            return boolPart;
        }

        private static Beam CreateSoldaduras(Point p1, Point p2, string perfil)
        {
            Beam myBeam = new Beam(new Point(p1),
                                    new Point(p2));
            myBeam.Name = "SOLDADURA";
            myBeam.Material.MaterialString = "Misc_Undefined";
            myBeam.Profile.ProfileString = perfil;
            myBeam.Position.Rotation = Position.RotationEnum.TOP;
            myBeam.Position.Plane = Position.PlaneEnum.MIDDLE;
            myBeam.Position.Depth = Position.DepthEnum.MIDDLE;
            myBeam.PartNumber.Prefix = "sol";
            myBeam.PartNumber.StartNumber = 1;
            myBeam.Class = "11";
            myBeam.Insert();

            return myBeam;
        }

        private static BooleanPart BoolNegativo(Part beam, Part DeletePart)
        {
            BooleanPart boolPart = new BooleanPart();
            boolPart.Father = beam;
            boolPart.SetOperativePart(DeletePart);

            if (!boolPart.Insert())
                Console.WriteLine("Insert failed!");

            return boolPart;
        }


        public static void defaultValueDIN934(double metRoscada, out double P, out double m, out double S)
        {
            P = 0;
            m = 0;
            S = 0;

            if (metRoscada == 6)
            {
                P = 1.0;
                m = 5.0;
                S = 10.0;
            }
            else if (metRoscada == 8)
            {
                P = 1.25;
                m = 6.5;
                S = 13.0;
            }
            else if (metRoscada == 10)
            {
                P = 1.5;
                m = 8.0;
                S = 17.0;
            }
            else if (metRoscada == 12)
            {
                P = 1.75;
                m = 10.0;
                S = 19.0;
            }
            else if (metRoscada == 16)
            {
                P = 2.0;
                m = 13.0;
                S = 24.0;
            }
            else if (metRoscada == 20)
            {
                P = 2.5;
                m = 16.0;
                S = 30.0;
            }
            else if (metRoscada == 24)
            {
                P = 3.0;
                m = 19.0;
                S = 36.0;
            }
            else if (metRoscada == 30)
            {
                P = 3.5;
                m = 24.0;
                S = 46.0;
            }
            else if (metRoscada == 36)
            {
                P = 4.0;
                m = 29.0;
                S = 55.0;
            }
            else if (metRoscada == 39)
            {
                P = 4.0;
                m = 31.0;
                S = 60.0;
            }
            else if (metRoscada == 42)
            {
                P = 4.5;
                m = 34.0;
                S = 65.0;
            }
            else if (metRoscada == 45)
            {
                P = 4.5;
                m = 36.0;
                S = 70.0;
            }
            else if (metRoscada == 48)
            {
                P = 5.0;
                m = 38.0;
                S = 75.0;
            }
            else if (metRoscada == 52)
            {
                P = 5.0;
                m = 42.0;
                S = 80.0;
            }
        }

    }
}
