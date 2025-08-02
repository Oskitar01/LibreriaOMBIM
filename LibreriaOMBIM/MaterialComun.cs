using LibreriaOMBIM.Conjuntos;
using System;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace LibreriaOMBIM.Tornilleria
{
    public sealed class MaterialComun
    {
        public static Beam TuercaComun(Point punto1, Point punto2, string name, string perfil, Part mainPart, string comment, string nombreGrupo, string prefijoGrupo)
        {
            Beam tuerca = new Beam(punto1, punto2);
            tuerca.Name = name;
            tuerca.Profile.ProfileString = perfil;
            tuerca.Position.Plane = Position.PlaneEnum.MIDDLE;
            tuerca.Position.Depth = Position.DepthEnum.MIDDLE;
            tuerca.Class = "4";
            tuerca.Material.MaterialString = "5";
            tuerca.AssemblyNumber.Prefix = "TU";
            tuerca.AssemblyNumber.StartNumber = 1;
            tuerca.PartNumber.Prefix = "tu";
            tuerca.PartNumber.StartNumber = 1;
            tuerca.Insert();

            CodigoProducto(name, tuerca);


            if (comment == "MONTAJE")
            {
                tuerca.SetUserProperty("ERECTION_CODE", prefijoGrupo);
                tuerca.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
                tuerca.SetUserProperty("comment", "MONTAJE");
                //tuerca.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                tuerca.SetUserProperty("comment", "CIMENTACION");
                //tuerca.Modify();

            }
            else if (comment == "FABRICACION")
            {
                tuerca.SetUserProperty("comment", "FABRICACION");

                //ReferenceBuilder.AddParteSubconjuntoFabricacion(mainPart, Tornilleria);
                //tuerca.Modify();

            }
            return tuerca;
        }

        public static Beam TuercaComun(string color, Point punto1, Point punto2, string name, string perfil, Part mainPart, string comment, string nombreGrupo, string prefijoGrupo)
        {
            Beam tuerca = new Beam(punto1, punto2);
            tuerca.Name = name;
            tuerca.Profile.ProfileString = perfil;
            tuerca.Position.Plane = Position.PlaneEnum.MIDDLE;
            tuerca.Position.Depth = Position.DepthEnum.MIDDLE;
            tuerca.Class = color;
            tuerca.Material.MaterialString = "5";
            tuerca.AssemblyNumber.Prefix = "TU";
            tuerca.AssemblyNumber.StartNumber = 1;
            tuerca.PartNumber.Prefix = "tu";
            tuerca.PartNumber.StartNumber = 1;
            tuerca.Insert();

            CodigoProducto(name, tuerca);

            if (comment == "MONTAJE")
            {
                tuerca.SetUserProperty("ERECTION_CODE", prefijoGrupo);
                tuerca.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
                tuerca.SetUserProperty("comment", "MONTAJE");
                //tuerca.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                tuerca.SetUserProperty("comment", "CIMENTACION");
                //tuerca.Modify();

            }
            else if (comment == "FABRICACION")
            {
                tuerca.SetUserProperty("comment", "FABRICACION");

                //ReferenceBuilder.AddParteSubconjuntoFabricacion(mainPart, Tornilleria);
                //tuerca.Modify();

            }
            return tuerca;
        }

        public static Beam TuercaComun(string color, Point punto1, Point punto2, string name, string perfil, string comment)
        {
            Beam tuerca = new Beam(punto1, punto2);
            tuerca.Name = name;
            tuerca.Profile.ProfileString = perfil;
            tuerca.Position.Plane = Position.PlaneEnum.MIDDLE;
            tuerca.Position.Depth = Position.DepthEnum.MIDDLE;
            tuerca.Class = color;
            tuerca.Material.MaterialString = "5";
            tuerca.AssemblyNumber.Prefix = "TU";
            tuerca.AssemblyNumber.StartNumber = 1;
            tuerca.PartNumber.Prefix = "tu";
            tuerca.PartNumber.StartNumber = 1;
            tuerca.Insert();

            CodigoProducto(name, tuerca);

            if (comment == "MONTAJE")
            {
               
                tuerca.SetUserProperty("comment", "MONTAJE");
                //tuerca.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                tuerca.SetUserProperty("comment", "CIMENTACION");
                //tuerca.Modify();

            }
            else if (comment == "FABRICACION")
            {
                tuerca.SetUserProperty("comment", "FABRICACION");

                //ReferenceBuilder.AddParteSubconjuntoFabricacion(mainPart, Tornilleria);
                //tuerca.Modify();

            }
            return tuerca;
        }

        public static Beam TuercaEspecial(string color, Point punto1, Point punto2, string name, string perfil, string material, string comment, string nombreGrupo, string prefijoGrupo, string prefijoParte)
        {
            Beam tuerca = new Beam(punto1, punto2);
            tuerca.Name = name;
            tuerca.Profile.ProfileString = perfil;
            tuerca.Position.Plane = Position.PlaneEnum.MIDDLE;
            tuerca.Position.Depth = Position.DepthEnum.MIDDLE;
            tuerca.Class = color;
            tuerca.Material.MaterialString = material;
            tuerca.AssemblyNumber.Prefix = prefijoGrupo;
            tuerca.AssemblyNumber.StartNumber = 1;
            tuerca.PartNumber.Prefix = prefijoParte;
            tuerca.PartNumber.StartNumber = 1;
            tuerca.Insert();

            CodigoProducto(name, tuerca);

            if (comment == "MONTAJE")
            {
                tuerca.SetUserProperty("ERECTION_CODE", prefijoGrupo);
                tuerca.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
                tuerca.SetUserProperty("comment", "MONTAJE");
                //tuerca.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                tuerca.SetUserProperty("comment", "CIMENTACION");
                //tuerca.Modify();

            }
            else if (comment == "FABRICACION")
            {
                tuerca.SetUserProperty("comment", "FABRICACION");

                //ReferenceBuilder.AddParteSubconjuntoFabricacion(mainPart, Tornilleria);
                //tuerca.Modify();

            }
            return tuerca;
        }

        public static Beam TuercaEspecial( Point punto1, Point punto2, string name, string perfil, string comment   )
        {
            Beam tuerca = new Beam(punto1, punto2);
            tuerca.Name = name;
            tuerca.Profile.ProfileString = perfil;
            tuerca.Position.Plane = Position.PlaneEnum.MIDDLE;
            tuerca.Position.Depth = Position.DepthEnum.MIDDLE;
            tuerca.Class = "4";

            tuerca.Material.MaterialString = "5";
            tuerca.AssemblyNumber.Prefix = "TU";
            tuerca.AssemblyNumber.StartNumber = 1;
            tuerca.PartNumber.Prefix = "tu";
            tuerca.PartNumber.StartNumber = 1;
            tuerca.Insert();


            if (comment == "MONTAJE")
            {
                
                tuerca.SetUserProperty("comment", "MONTAJE");
                //tuerca.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                tuerca.SetUserProperty("comment", "CIMENTACION");
                //tuerca.Modify();

            }
            else if (comment == "FABRICACION")
            {
                tuerca.SetUserProperty("comment", "FABRICACION");

                //tuerca.Modify();

            }
            return tuerca;
        }


        public static Beam ArandelaComun(Point punto1, Point punto2, string name, string perfil, Part mainPart, string comment, string nombreGrupo, string prefijoGrupo)
        {
            Beam arandela = new Beam(punto1, punto2);
            arandela.Name = name;
            arandela.Profile.ProfileString = perfil;
            arandela.Position.Plane = Position.PlaneEnum.MIDDLE;
            arandela.Position.Depth = Position.DepthEnum.MIDDLE;
            arandela.Class = "4";
            arandela.Material.MaterialString = "ST/HV100";
            arandela.AssemblyNumber.Prefix = "AR";
            arandela.AssemblyNumber.StartNumber = 1;
            arandela.PartNumber.Prefix = "ar";
            arandela.PartNumber.StartNumber = 1;
            arandela.Insert();

            CodigoProducto(name, arandela);

            if (comment == "MONTAJE")
            {
                arandela.SetUserProperty("ERECTION_CODE", prefijoGrupo);
                arandela.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
                arandela.SetUserProperty("comment", "MONTAJE");
                //arandela.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                arandela.SetUserProperty("comment", "CIMENTACION");
                //arandela.Modify();

            }
            else if (comment == "FABRICACION")
            {
                arandela.SetUserProperty("comment", "FABRICACION");

                //ReferenceBuilder.AddParteSubconjuntoFabricacion(mainPart, Tornilleria);
                //arandela.Modify();

            }
            return arandela;
        }

        public static Beam ArandelaComun(string color, Point punto1, Point punto2, string name, string perfil, string comment)
        {
            Beam arandela = new Beam(punto1, punto2);
            arandela.Name = name;
            arandela.Profile.ProfileString = perfil;
            arandela.Position.Plane = Position.PlaneEnum.MIDDLE;
            arandela.Position.Depth = Position.DepthEnum.MIDDLE;
            arandela.Class = color;
            arandela.Material.MaterialString = "ST/HV100";
            arandela.AssemblyNumber.Prefix = "AR";
            arandela.AssemblyNumber.StartNumber = 1;
            arandela.PartNumber.Prefix = "ar";
            arandela.PartNumber.StartNumber = 1;
            arandela.Insert();

            CodigoProducto(name, arandela);

            if (comment == "MONTAJE")
            {
                
                arandela.SetUserProperty("comment", "MONTAJE");
                //arandela.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                arandela.SetUserProperty("comment", "CIMENTACION");
                //arandela.Modify();

            }
            else if (comment == "FABRICACION")
            {
                arandela.SetUserProperty("comment", "FABRICACION");

                //ReferenceBuilder.AddParteSubconjuntoFabricacion(mainPart, Tornilleria);
                //arandela.Modify();

            }
            return arandela;
        }


        public static Beam ArandelaEspecial( Point punto1, Point punto2, string name, string perfil, string comment)
        {
            Beam arandela = new Beam(punto1, punto2);
            arandela.Name = name;
            arandela.Profile.ProfileString = perfil;
            arandela.Position.Plane = Position.PlaneEnum.MIDDLE;
            arandela.Position.Depth = Position.DepthEnum.MIDDLE;
            arandela.Class = "4";
            arandela.Material.MaterialString = "ST/HV100";
            arandela.AssemblyNumber.Prefix = "AR";
            arandela.AssemblyNumber.StartNumber = 1;
            arandela.PartNumber.Prefix = "ar";
            arandela.PartNumber.StartNumber = 1;
            arandela.Insert();


            if (comment == "MONTAJE")
            {

                arandela.SetUserProperty("comment", "MONTAJE");
                //arandela.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                arandela.SetUserProperty("comment", "CIMENTACION");
                //arandela.Modify();

            }
            else if (comment == "FABRICACION")
            {
                arandela.SetUserProperty("comment", "FABRICACION");

                arandela.Modify();

            }
            return arandela;
        }



        public static Beam ArandelaGrowerComun(Point punto1, Point punto2, string name, string perfil, Part mainPart, string comment, string nombreGrupo, string prefijoGrupo)
        {
            Beam grower = new Beam(punto1, punto2);
            grower.Name = name;
            grower.Profile.ProfileString = perfil;
            grower.Position.Plane = Position.PlaneEnum.MIDDLE;
            grower.Position.Depth = Position.DepthEnum.MIDDLE;
            grower.Class = "13";
            grower.Material.MaterialString = "ST/HV100";
            grower.AssemblyNumber.Prefix = "AG";
            grower.AssemblyNumber.StartNumber = 1;
            grower.PartNumber.Prefix = "ag";
            grower.PartNumber.StartNumber = 1;
            grower.Insert();

            CodigoProducto(name, grower);


            if (comment == "MONTAJE")
            {
                grower.SetUserProperty("ERECTION_CODE", prefijoGrupo);
                grower.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
                grower.SetUserProperty("comment", "MONTAJE");
                //grower.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                grower.SetUserProperty("comment", "CIMENTACION");
                //grower.Modify();

            }
            else if (comment == "FABRICACION")
            {
                grower.SetUserProperty("comment", "FABRICACION");

                //ReferenceBuilder.AddParteSubconjuntoFabricacion(mainPart, Tornilleria);
                //grower.Modify();

            }
            return grower;
        }

        public static Beam ArandelaGrowerComun(string color, Point punto1, Point punto2, string name, string perfil, string comment)
        {
            Beam grower = new Beam(punto1, punto2);
            grower.Name = name;
            grower.Profile.ProfileString = perfil;
            grower.Position.Plane = Position.PlaneEnum.MIDDLE;
            grower.Position.Depth = Position.DepthEnum.MIDDLE;
            grower.Class = color;
            grower.Material.MaterialString = "ST/HV100";
            grower.AssemblyNumber.Prefix = "AG";
            grower.AssemblyNumber.StartNumber = 1;
            grower.PartNumber.Prefix = "ag";
            grower.PartNumber.StartNumber = 1;
            grower.Insert();

            CodigoProducto(name, grower);


            if (comment == "MONTAJE")
            {
                
                grower.SetUserProperty("comment", "MONTAJE");
                //grower.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                grower.SetUserProperty("comment", "CIMENTACION");
                //grower.Modify();

            }
            else if (comment == "FABRICACION")
            {
                grower.SetUserProperty("comment", "FABRICACION");

                //ReferenceBuilder.AddParteSubconjuntoFabricacion(mainPart, Tornilleria);
                //grower.Modify();

            }
            return grower;
        }

        public static Brep TacoMecanico(Point Punto1, Point Punto2, string name, string perfil, Part mainPart, string nombreGrupo, string prefijoGrupo, Position.RotationEnum front)
        {
            Brep tacoMecanico = new Brep(Punto1, Punto2);

            tacoMecanico.Name = name;
            tacoMecanico.Profile.ProfileString = perfil;
            tacoMecanico.Position.Plane = Position.PlaneEnum.MIDDLE;
            tacoMecanico.Position.Depth = Position.DepthEnum.MIDDLE;
            tacoMecanico.Position.Rotation = front;
            tacoMecanico.Class = "4";
            tacoMecanico.Material.MaterialString = "ACERO";
            tacoMecanico.AssemblyNumber.Prefix = "TM";
            tacoMecanico.AssemblyNumber.StartNumber = 1;
            tacoMecanico.PartNumber.Prefix = "tm";
            tacoMecanico.PartNumber.StartNumber = 1;
            tacoMecanico.Insert();


            tacoMecanico.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
            tacoMecanico.SetUserProperty("ERECTION_CODE", prefijoGrupo);
            tacoMecanico.SetUserProperty("comment", "MONTAJE");


            CodigoProducto(perfil, tacoMecanico);


            //tacoMecanico.Modify();


            return tacoMecanico;
        }

        public static Brep TacoMecanico(Point Punto1, Point Punto2, string name, string perfil,   Position.RotationEnum front)
        {
            Brep tacoMecanico = new Brep(Punto1, Punto2);

            tacoMecanico.Name = name;
            tacoMecanico.Profile.ProfileString = perfil;
            tacoMecanico.Position.Plane = Position.PlaneEnum.MIDDLE;
            tacoMecanico.Position.Depth = Position.DepthEnum.MIDDLE;
            tacoMecanico.Position.Rotation = front;
            tacoMecanico.Class = "4";
            tacoMecanico.Material.MaterialString = "ACERO";
            tacoMecanico.AssemblyNumber.Prefix = "TM";
            tacoMecanico.AssemblyNumber.StartNumber = 1;
            tacoMecanico.PartNumber.Prefix = "tm";
            tacoMecanico.PartNumber.StartNumber = 1;
            tacoMecanico.Insert();


           
            tacoMecanico.SetUserProperty("comment", "MONTAJE");


            CodigoProducto(perfil, tacoMecanico);


            //tacoMecanico.Modify();


            return tacoMecanico;
        }

        public static Brep TornilloFer(Point Punto1, Point Punto2, string name, string perfil, Part mainPart, string comment, string color, string nombreGrupo, string prefijoGrupo, Position.RotationEnum front)
        {
            Brep tornilloFer = new Brep(Punto1, Punto2);

            tornilloFer.Name = name;
            tornilloFer.Profile.ProfileString = perfil;
            tornilloFer.Position.Plane = Position.PlaneEnum.MIDDLE;
            tornilloFer.Position.Depth = Position.DepthEnum.MIDDLE;
            tornilloFer.Position.Rotation = front;
            tornilloFer.Class = "4";
            tornilloFer.Material.MaterialString = "ACERO";
            tornilloFer.AssemblyNumber.Prefix = "TF";
            tornilloFer.AssemblyNumber.StartNumber = 1;
            tornilloFer.PartNumber.Prefix = "tf";
            tornilloFer.PartNumber.StartNumber = 1;
            tornilloFer.Insert();


            tornilloFer.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
            tornilloFer.SetUserProperty("ERECTION_CODE", prefijoGrupo);
            tornilloFer.SetUserProperty("comment", comment);

            CodigoProducto(perfil, tornilloFer);

            //tornilloFer.Modify();


            return tornilloFer;
        }

        public static Beam TuercaNoxifer(Point punto1, Point punto2, string name, string perfil, Part mainPart, string comment, string nombreGrupo, string prefijoGrupo)
        {
            Beam tuerca = new Beam(punto1, punto2);
            tuerca.Name = name;
            tuerca.Profile.ProfileString = perfil;
            tuerca.Position.Plane = Position.PlaneEnum.MIDDLE;
            tuerca.Position.Depth = Position.DepthEnum.MIDDLE;
            tuerca.Class = "4";
            tuerca.Material.MaterialString = "5";
            tuerca.AssemblyNumber.Prefix = "TU";
            tuerca.AssemblyNumber.StartNumber = 1;
            tuerca.PartNumber.Prefix = "tu";
            tuerca.PartNumber.StartNumber = 1;
            tuerca.Insert();

            tuerca.SetUserProperty("PRODUCT_CODE", "Y1HW");
            tuerca.SetUserProperty("PRODUCT_UNIT", "ud");

            if (comment == "MONTAJE")
            {
                tuerca.SetUserProperty("ERECTION_CODE", prefijoGrupo);
                tuerca.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
                tuerca.SetUserProperty("comment", "MONTAJE");
                //tuerca.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                tuerca.SetUserProperty("comment", "CIMENTACION");
                //tuerca.Modify();

            }
            else if (comment == "FABRICACION")
            {
                tuerca.SetUserProperty("comment", "FABRICACION");

                //ReferenceBuilder.AddParteSubconjuntoFabricacion(mainPart, Tornilleria);
                //tuerca.Modify();

            }
            return tuerca;
        }

        public static Beam ArandelaNoxifer(Point punto1, Point punto2, string name, string perfil, Part mainPart, string comment, string nombreGrupo, string prefijoGrupo)
        {
            Beam arandela = new Beam(punto1, punto2);
            arandela.Name = name;
            arandela.Profile.ProfileString = perfil;
            arandela.Position.Plane = Position.PlaneEnum.MIDDLE;
            arandela.Position.Depth = Position.DepthEnum.MIDDLE;
            arandela.Class = "4";
            arandela.Material.MaterialString = "ST/HV100";
            arandela.AssemblyNumber.Prefix = "AR";
            arandela.AssemblyNumber.StartNumber = 1;
            arandela.PartNumber.Prefix = "ar";
            arandela.PartNumber.StartNumber = 1;
            arandela.Insert();

            arandela.SetUserProperty("PRODUCT_CODE", "Y1HD");
            arandela.SetUserProperty("PRODUCT_UNIT", "ud");
            if (comment == "MONTAJE")
            {
                arandela.SetUserProperty("ERECTION_CODE", prefijoGrupo);
                arandela.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
                arandela.SetUserProperty("comment", "MONTAJE");
                //arandela.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                arandela.SetUserProperty("comment", "CIMENTACION");
                //arandela.Modify();

            }
            else if (comment == "FABRICACION")
            {
                arandela.SetUserProperty("comment", "FABRICACION");

                //ReferenceBuilder.AddParteSubconjuntoFabricacion(mainPart, Tornilleria);
                //arandela.Modify();

            }
            return arandela;
        }

        public static Beam ArandelaGrowerNoxifer(Point punto1, Point punto2, string name, string perfil, Part mainPart, string comment, string nombreGrupo, string prefijoGrupo)
        {
            Beam grower = new Beam(punto1, punto2);
            grower.Name = name;
            grower.Profile.ProfileString = perfil;
            grower.Position.Plane = Position.PlaneEnum.MIDDLE;
            grower.Position.Depth = Position.DepthEnum.MIDDLE;
            grower.Class = "13";
            grower.Material.MaterialString = "ST/HV100";
            grower.AssemblyNumber.Prefix = "AG";
            grower.AssemblyNumber.StartNumber = 1;
            grower.PartNumber.Prefix = "ag";
            grower.PartNumber.StartNumber = 1;
            grower.Insert();

            grower.SetUserProperty("PRODUCT_CODE", "Y1HE");
            grower.SetUserProperty("PRODUCT_UNIT", "ud");

            if (comment == "MONTAJE")
            {
                grower.SetUserProperty("ERECTION_CODE", prefijoGrupo);
                grower.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
                grower.SetUserProperty("comment", "MONTAJE");
                //grower.Modify();

            }
            else if (comment == "CIMENTACION")
            {
                grower.SetUserProperty("comment", "CIMENTACION");
                //grower.Modify();

            }
            else if (comment == "FABRICACION")
            {
                grower.SetUserProperty("comment", "FABRICACION");

                //ReferenceBuilder.AddParteSubconjuntoFabricacion(mainPart, Tornilleria);
                //grower.Modify();

            }
            return grower;
        }

        public static Brep CarrilNoxifer(Point Punto1, Point Punto2, string name, string perfil, Part mainPart, string color, Position.RotationEnum front)
        {
            string profile = "NOX-" + perfil;

            Brep carril = new Brep(Punto1, Punto2);

            carril.Name = "PERFIL "+perfil;
            carril.Profile.ProfileString = profile;
            carril.Position.Plane = Position.PlaneEnum.MIDDLE;
            carril.Position.Depth = Position.DepthEnum.MIDDLE;
            carril.Position.Rotation = front;
            carril.Class = color;
            carril.Material.MaterialString = "ACERO";
            carril.AssemblyNumber.Prefix = "PERFIL";
            carril.AssemblyNumber.StartNumber = 1;
            carril.PartNumber.Prefix = "perfil";
            carril.PartNumber.StartNumber = 1;
            carril.Insert();

            carril.SetUserProperty("comment", "FABRICACION");
            CodigoProducto(perfil, carril);
            Soldaduras.AddParteAColadaSubconjuntoTaller(mainPart, carril);

            //carril.Modify();


            return carril;
        }

        public static Beam ArandelaFer(Point punto1, Point punto2, string name, string perfil, Part mainPart, string nombreGrupo, string prefijoGrupo)
        {
            Beam arandelaFer = new Beam(punto1, punto2);
            arandelaFer.Name = name;
            arandelaFer.Profile.ProfileString = perfil;
            arandelaFer.Position.Plane = Position.PlaneEnum.MIDDLE;
            arandelaFer.Position.Depth = Position.DepthEnum.MIDDLE;
            arandelaFer.Class = "3";
            arandelaFer.Material.MaterialString = "ACERO";
            arandelaFer.AssemblyNumber.Prefix = "AF";
            arandelaFer.AssemblyNumber.StartNumber = 1;
            arandelaFer.PartNumber.Prefix = "af";
            arandelaFer.PartNumber.StartNumber = 1;
            arandelaFer.Insert();

            arandelaFer.SetUserProperty("ERECTION_CODE", prefijoGrupo);
            arandelaFer.SetUserProperty("ERECTION_COMMENT", nombreGrupo);

            arandelaFer.SetUserProperty("comment", "MONTAJE");

            CodigoProducto(name, arandelaFer);
            //arandelaFer.Modify();


            return arandelaFer;
        }

        public static Brep GRAP_Noxifer(Point Punto1, Point Punto2, string name, string perfil, Part mainPart, string nombreGrupo, string prefijoGrupo, Position.RotationEnum front)
        {
            Brep grap = new Brep(Punto1, Punto2);

            grap.Name = "ANCLAJE "+perfil ; 
            grap.Profile.ProfileString = perfil;
            grap.Position.Plane = Position.PlaneEnum.MIDDLE;
            grap.Position.Depth = Position.DepthEnum.MIDDLE;
            grap.Position.Rotation = front;
            grap.Class = "4";
            grap.Material.MaterialString = "ACERO";
            grap.AssemblyNumber.Prefix = "GRAP";
            grap.AssemblyNumber.StartNumber = 1;
            grap.PartNumber.Prefix = "grap";
            grap.PartNumber.StartNumber = 1;
            grap.Insert();


            grap.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
            grap.SetUserProperty("ERECTION_CODE", prefijoGrupo);
            grap.SetUserProperty("comment", "MONTAJE");

            grap.SetUserProperty("PRODUCT_UNIT", "ud");
            //grap.Modify();
            CodigoProducto(name, grap);

            return grap;
        }

        public static Brep Cofi_Noxifer(Point Punto1, Point Punto2, string name, string perfil, Part mainPart, string nombreGrupo, string prefijoGrupo, Position.RotationEnum front)
        {
            string profile = "NOX-" + perfil;


            Brep cofi = new Brep(Punto1, Punto2);

            cofi.Name = "ANCLAJE " +perfil; 
            cofi.Profile.ProfileString = profile;
            cofi.Position.Plane = Position.PlaneEnum.MIDDLE;
            cofi.Position.Depth = Position.DepthEnum.MIDDLE;
            cofi.Position.Rotation = front;
            cofi.Class = "4";
            cofi.Material.MaterialString = "ACERO";
            cofi.AssemblyNumber.Prefix = "COFI";
            cofi.AssemblyNumber.StartNumber = 1;
            cofi.PartNumber.Prefix = "cofi";
            cofi.PartNumber.StartNumber = 1;
            cofi.Insert();


            cofi.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
            cofi.SetUserProperty("ERECTION_CODE", prefijoGrupo);
            cofi.SetUserProperty("comment", "MONTAJE");

            CodigoProducto(name, cofi);
            //cofi.Modify();


            return cofi;
        }

        public static Brep UPA_Noxifer(Point Punto1, Point Punto2, string name, string perfil, Part mainPart, string nombreGrupo, string prefijoGrupo, Position.RotationEnum front)
        {
            string profile = "NOX-" + perfil;

            Brep UPA = new Brep(Punto1, Punto2);

            UPA.Name = "ANCLAJE "+perfil;
            UPA.Profile.ProfileString = profile;
            UPA.Position.Plane = Position.PlaneEnum.MIDDLE;
            UPA.Position.Depth = Position.DepthEnum.MIDDLE;
            UPA.Position.Rotation = front;
            UPA.Class = "4";
            UPA.Material.MaterialString = "ACERO";
            UPA.AssemblyNumber.Prefix = "UPA";
            UPA.AssemblyNumber.StartNumber = 1;
            UPA.PartNumber.Prefix = "upa";
            UPA.PartNumber.StartNumber = 1;
            UPA.Insert();


            UPA.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
            UPA.SetUserProperty("ERECTION_CODE", prefijoGrupo);
            UPA.SetUserProperty("comment", "MONTAJE");

            CodigoProducto(name, UPA);

            //UPA.Modify();


            return UPA;
        }

        public static Brep Oculfix_Noxifer(Point Punto1, Point Punto2, string name, string perfil, Part mainPart, Position.RotationEnum front)
        {
            string profile = "NOX-" + perfil;

            Brep oculfix = new Brep(Punto1, Punto2);

            oculfix.Name = name;
            oculfix.Profile.ProfileString = profile;
            oculfix.Position.Plane = Position.PlaneEnum.MIDDLE;
            oculfix.Position.Depth = Position.DepthEnum.MIDDLE;
            oculfix.Position.Rotation = front;
            oculfix.Class = "4";
            oculfix.Material.MaterialString = "ACERO";
            oculfix.AssemblyNumber.Prefix = "OCU";
            oculfix.AssemblyNumber.StartNumber = 1;
            oculfix.PartNumber.Prefix = "ocu";
            oculfix.PartNumber.StartNumber = 1;
            oculfix.Insert();


            oculfix.SetUserProperty("comment", "FABRICACION");

            CodigoProducto(perfil, oculfix);

            //ReferenceBuilder.AddParteSubconjuntoFabricacion(mainPart, carril);
            Soldaduras.AddParteAColadaSubconjuntoTaller(mainPart, oculfix);


            //oculfix.Modify();


            return oculfix;
        }


        public static Beam TuboPVC(Part PrimaryBeam, Point p1, Point p2, string perfil)
        {
            Char trimChar = '*';
            string PERF = perfil;
            PERF = PERF.Replace("PVC", "");
            int index = PERF.IndexOf(trimChar);
            PERF = PERF.Remove(index);


            Beam tuboPVC = new Beam(p1, p2);
            tuboPVC.Name = "TUBO PVC "+PERF;
            tuboPVC.Profile.ProfileString = perfil;
            tuboPVC.Position.Plane = Position.PlaneEnum.MIDDLE;
            tuboPVC.Position.Depth = Position.DepthEnum.MIDDLE;
            tuboPVC.Class = "14";
            tuboPVC.Material.MaterialString = "PVC";
            tuboPVC.AssemblyNumber.Prefix = "PVC";
            tuboPVC.AssemblyNumber.StartNumber = 1;
            tuboPVC.PartNumber.Prefix = "pvc";
            tuboPVC.PartNumber.StartNumber = 1;
            tuboPVC.Insert();



            string pedido = "FABRICACION";
            tuboPVC.SetUserProperty("comment", pedido);

            //double longitud = 0.0;
            //tuboPVC.GetReportProperty("LENGTH", ref longitud);
            //longitud = Math.Round(longitud, 1);

            //string ALLPLAN = "";
            //ALLPLAN = "PVC" + "  " + perfil + "  " + "L= " + longitud.ToString() + " mm";
            //tuboPVC.SetUserProperty("ALLPLAN", ALLPLAN);
            LibreriaOMBIM.Tornilleria.MaterialComun.CodigoProductoLineales(tuboPVC.Name, tuboPVC);

            //tuboPVC.Modify();

            Part myPart = PrimaryBeam as Part;
            //assemblyFabricacion(tuboPVC, myPart);
            ReferenceBuilder.AddParteSubconjuntoFabricacion(myPart, tuboPVC);

            return tuboPVC;
        }



        public static string CodigoProducto(string perfil, Part mainPart)
        {
             string valor="";

            if(perfil.Contains("TUERCA M12"))
            {
                valor = "Y1IX";
            }
            else if (perfil.Contains("TUERCA M16"))
            {
                valor = "Y1IY";
            }
            else if (perfil.Contains("TUERCA M20"))
            {
                valor = "Y1IZ";
            }
            else if (perfil.Contains("TUERCA M24"))
            {
                valor = "Y1J0";
            }
            else if (perfil.Contains("TUERCA M27"))
            {
                valor = "Y1J1";
            }
            else if (perfil.Contains("TUERCA M30"))
            {
                valor = "Y1J2";
            }
            else if (perfil.Contains("TUERCA M33"))
            {
                valor = "Y1J3";
            }
            else if (perfil.Contains("TUERCA M36"))
            {
                valor = "";
            }
            else if (perfil.Contains("TUERCA M39"))
            {
                valor = "Y1J4";
            }
            else if (perfil.Contains("TUERCA M45"))
            {
                valor = "";
            }
            else if (perfil.Contains("TUERCA M52"))
            {
                valor = "";
            }

            else if (perfil.Contains("ARANDELA A12"))
            {
                valor = "Y1IH";
            }
            else if (perfil.Contains("ARANDELA A16"))
            {
                valor = "Y1II";
            }
            else if (perfil.Contains("ARANDELA A20"))
            {
                valor = "Y1IJ";
            }
            else if (perfil.Contains("ARANDELA A24"))
            {
                valor = "Y1IK";
            }
            else if (perfil.Contains("ARANDELA A27"))
            {
                valor = "Y1IL";
            }
            else if (perfil.Contains("ARANDELA A30"))
            {
                valor = "Y1IM";
            }
            else if (perfil.Contains("ARANDELA A33"))
            {
                valor = "Y1IN";
            }
            else if (perfil.Contains("ARANDELA A36"))
            {
                valor = "";
            }
            else if (perfil.Contains("ARANDELA A39"))
            {
                valor = "Y1IO";
            }
            else if (perfil.Contains("ARANDELA A45"))
            {
                valor = "";
            }
            else if (perfil.Contains("ARANDELA A52"))
            {
                valor = "";
            }


            else if (perfil.Contains("ARANDELA M12"))
            {
                valor = "Y1IH";
            }
            else if (perfil.Contains("ARANDELA M16"))
            {
                valor = "Y1II";
            }
            else if (perfil.Contains("ARANDELA M20"))
            {
                valor = "Y1IJ";
            }
            else if (perfil.Contains("ARANDELA M24"))
            {
                valor = "Y1IK";
            }
            else if (perfil.Contains("ARANDELA M27"))
            {
                valor = "Y1IL";
            }
            else if (perfil.Contains("ARANDELA M30"))
            {
                valor = "Y1IM";
            }
            else if (perfil.Contains("ARANDELA M33"))
            {
                valor = "Y1IN";
            }
            else if (perfil.Contains("ARANDELA M36"))
            {
                valor = "";
            }
            else if (perfil.Contains("ARANDELA M39"))
            {
                valor = "Y1IO";
            }
            else if (perfil.Contains("ARANDELA M45"))
            {
                valor = "";
            }
            else if (perfil.Contains("ARANDELA M52"))
            {
                valor = "";
            }

            else if (perfil.Contains("GROWER AG12"))
            {
                valor = "Y1IP";
            }
            else if (perfil.Contains("GROWER AG16"))
            {
                valor = "Y1IQ";
            }
            else if (perfil.Contains("GROWER AG20"))
            {
                valor = "Y1IR";
            }
            else if (perfil.Contains("GROWER AG24"))
            {
                valor = "Y1IS";
            }
            else if (perfil.Contains("GROWER AG27"))
            {
                valor = "Y1IT";
            }
            else if (perfil.Contains("GROWER AG30"))
            {
                valor = "Y1IU";
            }
            else if (perfil.Contains("GROWER AG33"))
            {
                valor = "Y1IV";
            }
            else if (perfil.Contains("GROWER AG36"))
            {
                valor = "";
            }
            else if (perfil.Contains("GROWER AG39"))
            {
                valor = "Y1IW";
            }
            else if (perfil.Contains("GROWER AG45"))
            {
                //valor = "";
            }
            else if (perfil.Contains("GROWER AG52"))
            {
                //valor = "";
            }

            else if (perfil.Contains("ARANDELA-FER AF6/16"))
            {
                valor = "Y1HN";
            }
            else if (perfil.Contains("ARANDELA-FER AF8/16"))
            {
                valor = "Y1HO";
            }
            else if (perfil.Contains("GRAP"))
            {
                valor = "Y1HC";
            }
            else if (perfil.Contains("T-8-C"))
            {
                valor = "Y34Z";
            }
            else if (perfil.Contains("T-8-L"))
            {
                valor = "Y6D7";
            }
            else if (perfil.Contains("T-9-C"))
            {
                valor = "Y6D8";
            }
            else if (perfil.Contains("T-9-L"))
            {
                valor = "Y6D9";
            }
            else if (perfil.Contains("T-10-C"))
            {
                valor = "Y6DA";
            }
            else if (perfil.Contains("T-10-L"))
            {
                valor = "Y6DB";
            }
            else if (perfil.Contains("T-11-C"))
            {
                valor = "Y6DC";
            }
            else if (perfil.Contains("T-11-L"))
            {
                valor = "Y6DD";
            }
            


            else if (perfil.Contains("T-12-C"))
            {
                valor = "Y1E4";
            }
            else if (perfil.Contains("T-12-L"))
            {
                valor = "Y1E5";
            }
            else if (perfil.Contains("T-14-C"))
            {
                valor = "Y6DE";
            }
            else if (perfil.Contains("T-14-L"))
            {
                valor = "Y6DF";
            }
            else if (perfil.Contains("T-16-C"))
            {
                valor = "Y1E6";
            }
            else if (perfil.Contains("T-16-L"))
            {
                valor = "Y1E7";
            }
            else if (perfil.Contains("T-21"))
            {
                valor = "Y1E8";
            }
            else if (perfil.Contains("T-26"))
            {
                valor = "Y1E9";
            }


            else if (perfil.Contains("PN240R"))
            {
                valor = "Y1GR";
            }
            else if (perfil.Contains("PN240C"))
            {
                valor = "Y1GO";
            }
            else if (perfil.Contains("PN200S"))
            {
                valor = "Y1GS";
            }



            else if (perfil.Contains("OCULFIX-10"))
            {
                valor = "Y1GT";
            }
            else if (perfil.Contains("OCULFIX-20"))
            {
                valor = "Y1GU";
            }
            else if (perfil.Contains("OCULFIX-30"))
            {
                //valor = "";
            }
            else if (perfil.Contains("OCULFIX-40"))
            {
                valor = "Y1GV";
            }

            else if (perfil.Contains("COFI-TL120"))
            {
                valor = "Y1HJ";
            }
            else if (perfil.Contains("COFI-TL168"))
            {
                valor = "Y1HK";
            }
            else if (perfil.Contains("COFI-TL210"))
            {
                valor = "Y1HL";
            }
            else if (perfil.Contains("COFI-TL243"))
            {
                valor = "Y1HM";
            }

            else if (perfil.Contains("COFI-TL120(ø17)"))
            {
                valor = "Y6FG";
            }
            else if (perfil.Contains("COFI-TL168(ø17)"))
            {
                valor = "Y6FH";
            }
            else if (perfil.Contains("COFI-TL210(ø17)"))
            {
                valor = "Y6FI";
            }
            else if (perfil.Contains("COFI-TL243(ø17)"))
            {
                valor = "Y6FJ";
            }
            else if (perfil.Contains("COFI120"))
            {
                valor = "Y1HF";
            }
            else if (perfil.Contains("COFI168"))
            {
                valor = "Y1HG";
            }
            else if (perfil.Contains("COFI210"))
            {
                valor = "Y1HH";
            }
            else if (perfil.Contains("COFI243"))
            {
                valor = "Y2D9";
            }

            else if (perfil.Contains("UPA115"))
            {
                valor = "Y1HX";
            }
            else if (perfil.Contains("UPA145"))
            {
                valor = "Y1HY";
            }
            else if (perfil.Contains("UPA320"))
            {
                valor = "Y1HZ";
            }
            else if (perfil.Contains("UPA-C115"))
            {
                valor = "Y1I0";
            }
            else if (perfil.Contains("UPA-C145"))
            {
                valor = "Y1I1";
            }
            else if (perfil.Contains("UPA-C320"))
            {
                valor = "Y1I2";
            }
            else if (perfil.Contains("UPA-CTL115"))
            {
                valor = "Y1I3";
            }
            else if (perfil.Contains("UPA-CTL145"))
            {
                valor = "Y1I4";
            }
            else if (perfil.Contains("UPA-CTL320"))
            {
                valor = "Y1I5";
            }
            else if (perfil.Contains("UPA-TL115"))
            {
                valor = "Y1I6";
            }
            else if (perfil.Contains("UPA-TL145"))
            {
                valor = "Y1I7";
            }
            else if (perfil.Contains("UPA-TL320"))
            {
                valor = "Y1I8";
            }

            else if (perfil.Contains("UPA-TL115(ø17)"))
            {
                valor = "Y6FK";
            }
            else if (perfil.Contains("UPA-TL145(ø17)"))
            {
                valor = "Y6FL";
            }
            else if (perfil.Contains("UPA-TL320(ø17)"))
            {
                valor = "Y6FM";
            }


            else if (perfil.Contains("TF16-60"))
            {
                valor = "Y1HR";
            }
            else if (perfil.Contains("TF16-110"))
            {
                valor = "Y1HP";
            }
            else if (perfil.Contains("TF16-140"))
            {
                valor = "Y1HQ";
            }
            else if (perfil.Contains("TF16-90"))
            {
                valor = "Y1HS";
            }


            else if (perfil.Contains("ARANDELA EN CUÑA 14% M12"))
            {
                valor = "Y6DI";
            }
            else if (perfil.Contains("ARANDELA EN CUÑA 14% M16"))
            {
                valor = "Y6DJ";
            }
            else if (perfil.Contains("ARANDELA EN CUÑA 14% M20"))
            {
                valor = "Y6DK";
            }
            else if (perfil.Contains("ARANDELA EN CUÑA 14% M24"))
            {
                valor = "Y4N5";
            }

            else if (perfil.Contains("CASQUILLO"))
            {
                //valor = "";
            }

            else if (perfil.Contains("PLA-MT2"))
            {
                //valor = "";
            }
            else if (perfil.Contains("PLA-MT4"))
            {
                valor = "Y1H4";
            }
            else if (perfil.Contains("PLA-MT6"))
            {
                valor = "Y1H1";
            }
            else if (perfil.Contains("PLA-MT9"))
            {
                valor = "Y1GZ";
            }
            else if (perfil.Contains("PLA-MT12"))
            {
                valor = "Y1GW";
            }

            else if (perfil.Contains("REP-MT2"))
            {
                //valor = "";
            }
            else if (perfil.Contains("REP-MT4"))
            {
                valor = "Y1H5";
            }
            else if (perfil.Contains("REP-MT6"))
            {
                valor = "Y1H2";
            }
            else if (perfil.Contains("REP-MT9"))
            {
                valor = "Y1GX";
            }
            else if (perfil.Contains("REP-MT12"))
            {
                valor = "Y1GX";
            }

            else if (perfil.Contains("MEN-MT2"))
            {
                //valor = "";
            }
            else if (perfil.Contains("MEN-MT4"))
            {
                valor = "Y1H6";
            }
            else if (perfil.Contains("MEN-MT6"))
            {
                valor = "Y1H3";
            }
            else if (perfil.Contains("MEN-MT9"))
            {
                valor = "Y1H0";
            }
            else if (perfil.Contains("MEN-MT12"))
            {
                valor = "Y1GY";
            }

            //else if (perfil.Contains("OMEGA 30"))
            //{
            //    valor = "Y1IA";
            //}
            //else if (perfil.Contains("OMEGA 40"))
            //{
            //    valor = "Y1IC";
            //}

            else if (perfil.Contains("TUBO 40*4 L=250 1Ø14"))
            {
                valor = "Y1ID";
            }

            else if (perfil.Contains("VARILLA ROSCADA M12"))
            {
                valor = "Y1BD";
            }
            else if (perfil.Contains("VARILLA ROSCADA M16"))
            {
                valor = "Y1BF";
            }
            else if (perfil.Contains("VARILLA ROSCADA M20"))
            {
                valor = "Y1BH";
            }
            else if (perfil.Contains("VARILLA ROSCADA M24"))
            {
                valor = "Y1BJ";
            }
            else if (perfil.Contains("VARILLA ROSCADA M27"))
            {
                valor = "Y6DH";
            }
            else if (perfil.Contains("VARILLA ROSCADA M30"))
            {
                valor = "Y1BK";
            }
            else if (perfil.Contains("VARILLA ROSCADA M33"))
            {
                valor = "Y1BL";
            }
            else if (perfil.Contains("VARILLA ROSCADA M39"))
            {
                valor = "Y1BM";
            }

            //else if (perfil.Contains("100*100*5") || perfil.Contains("5*100*100"))
            //{
            //    valor = "Y1D1";
            //}
            //else if (perfil.Contains("100*100*10")|| perfil.Contains("10*100*100"))
            //{
            //    valor = "Y1CZ";
            //}
            //else if (perfil.Contains("100*100*2") || perfil.Contains("2*100*100"))
            //{
            //    valor = "Y1D0";
            //}
            //else if (perfil.Contains("100*100*20") || perfil.Contains("20*100*100"))
            //{
            //    valor = "Y1D9";
            //}
            //else if (perfil.Contains("100*40*1"))
            //{
            //    valor = "Y1DB";
            //}
            //else if (perfil.Contains("100*40*10"))
            //{
            //    valor = "Y1DC";
            //}
            //else if (perfil.Contains("100*40*2"))
            //{
            //    valor = "Y1DD";
            //}
            //else if (perfil.Contains("100*40*5"))
            //{
            //    valor = "Y1DE";
            //}
            //else if (perfil.Contains("100*50*1"))
            //{
            //    valor = "Y1DF";
            //}
            //else if (perfil.Contains("100*85*10"))
            //{
            //    valor = "Y1DG";
            //}
            //else if (perfil.Contains("100*85*20"))
            //{
            //    valor = "Y1DH";
            //}
            //else if (perfil.Contains("100*85*3"))
            //{
            //    valor = "Y1DI";
            //}
            //else if (perfil.Contains("100*85*5"))
            //{
            //    valor = "Y1DJ";
            //}
            //else if (perfil.Contains("160*160*10"))
            //{
            //    valor = "Y1DK";
            //}
            //else if (perfil.Contains("160*160*2"))
            //{
            //    valor = "Y1DL";
            //}
            //else if (perfil.Contains("160*160*5"))
            //{
            //    valor = "Y1DM";
            //}
            //else if (perfil.Contains("80*80*2"))
            //{
            //    valor = "Y1DP";
            //}
            //else if (perfil.Contains("80*80*3"))
            //{
            //    valor = "Y1DQ";
            //}
            //else if (perfil.Contains("80*80*5"))
            //{
            //    valor = "Y1DR";
            //}
            //else if (perfil.Contains("80*80*8"))
            //{
            //    valor = "Y1DS";
            //}


            else if (perfil.Contains("TAPE P16"))
            {
                valor = "Y1C3";
            }
            else if (perfil.Contains("TAPE P20"))
            {
                valor = "Y1C4";
            }
            else if (perfil.Contains("TAPE P25"))
            {
                valor = "Y1C5";
            }
            else if (perfil.Contains("TAPE P30"))
            {
                valor = "Y1C6";
            }
            


            else if (perfil.Contains("TAPE E35 CENTRAL"))
            {
                valor = "Y1BX";
            }
            else if (perfil.Contains("TAPE E35 EXTREMO"))
            {
                valor = "Y1BY";
            }
           
            else if (perfil.Contains("TAPE E40 CENTRAL"))
            {
                valor = "Y1BZ";
            }
            else if (perfil.Contains("TAPE E40 EXTREMO"))
            {
                valor = "Y1C0";
            }
            else if (perfil.Contains("TAPE E50 CENTRAL"))
            {
                valor = "Y1C1";
            }
            else if (perfil.Contains("TAPE E50 EXTREMO"))
            {
                valor = "Y1C2";
            }
            else if (perfil.Contains("TAPE P63 CENTRAL"))
            {
                valor = "Y30I";
            }
            else if (perfil.Contains("TAPE P63 EXTREMO"))
            {
                valor = "Y1C7";
            }
            else if (perfil.Contains("TAPE Q35 CENTRAL"))
            {
                valor = "Y1C8";
            }
            else if (perfil.Contains("TAPE Q35 EXTREMO"))
            {
                valor = "Y1C9";
            }
          


            if (!valor.Equals(""))
                mainPart.SetUserProperty("PRODUCT_CODE", valor);
            mainPart.SetUserProperty("PRODUCT_UNIT", "ud");


            //mainPart.Modify();


            return valor;
        }
        public static string CodigoProducto(string perfil, Part mainPart,string material)
        {
            string valor = "";
           

            if (perfil.Contains("100*100*5") || perfil.Contains("5*100*100"))
            {
                if(material.Contains("PVC"))
                valor = "Y1DA";
                else
                    valor = "Y1D1";
            }
            else if (perfil.Contains("100*100*10") || perfil.Contains("10*100*100"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1D7";
                else
                    valor = "Y1CZ";
            }
            else if (perfil.Contains("100*100*2") || perfil.Contains("2*100*100"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1D8";
                else
                    valor = "Y1D0";
            }
            else if (perfil.Contains("100*100*20") || perfil.Contains("20*100*100"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1D9";
                
            }




            if (perfil.Contains("200*200*5") || perfil.Contains("5*200*200"))
            {
                if (!material.Contains("PVC"))
                    valor = "Y1D5";
               
            }
            else if (perfil.Contains("200*200*10") || perfil.Contains("10*200*200"))
            {
                if (!material.Contains("PVC"))
                    valor = "Y1D2";
               
            }
            else if (perfil.Contains("200*200*2") || perfil.Contains("2*200*200"))
            {
                if (!material.Contains("PVC"))
                    valor = "Y1D3";
              
            }
            else if (perfil.Contains("200*200*20") || perfil.Contains("20*200*200"))
            {
                if (!material.Contains("PVC"))
                    valor = "Y1D4";

            }














            else if (perfil.Contains("100*40*1"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DB";
            }
            else if (perfil.Contains("100*40*10"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DC";
            }
            else if (perfil.Contains("100*40*2"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DD";
            }
            else if (perfil.Contains("100*40*5"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DE";
            }
            else if (perfil.Contains("100*50*1"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DF";
            }
            else if (perfil.Contains("100*85*10"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DG";
            }
            else if (perfil.Contains("100*85*20"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DH";
            }
            else if (perfil.Contains("100*85*3"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DI";
            }
            else if (perfil.Contains("100*85*5"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DJ";
            }
            else if (perfil.Contains("160*160*10")|| perfil.Contains("10*160*160") || perfil.Contains("160*10*160"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DK";
            }
            else if (perfil.Contains("160*160*2") || perfil.Contains("2*160*160") || perfil.Contains("160*2*160"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DL";
            }
            else if (perfil.Contains("160*160*5") || perfil.Contains("5*160*160") || perfil.Contains("160*5*160"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DM";
            }
            else if (perfil.Contains("80*80*2"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DP";
            }
            else if (perfil.Contains("80*80*3"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DQ";
            }
            else if (perfil.Contains("80*80*5"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DR";
            }
            else if (perfil.Contains("80*80*8"))
            {
                if (material.Contains("PVC"))
                    valor = "Y1DS";
            }


        


            if (!valor.Equals(""))
                mainPart.SetUserProperty("PRODUCT_CODE", valor);
            mainPart.SetUserProperty("PRODUCT_UNIT", "ud");


            //mainPart.Modify();


            return valor;
        }


        public static string CodigoProductoElevacion(string perfil, Part mainPart)
        {
            string valor = "";

            if (perfil.Contains("DEHA 2.5Tn"))
            {
                valor = "Y19Q";
            }
            else if (perfil.Contains("DEHA 5.0Tn"))
            {
                valor = "Y19R";
            }
            else if (perfil.Contains("DEHA 7.5Tn"))
            {
                valor = "Y19S";
            }
            else if (perfil.Contains("DEHA 10Tn"))
            {
                valor = "Y19O";
            }
            else if (perfil.Contains("DEHA 15Tn"))
            {
                valor = "Y19P";
            }



            else if (perfil.Contains("FRIMEDA 1.4Tn"))
            {
                valor = "Y1A7";
            }
            else if (perfil.Contains("FRIMEDA 2.5Tn"))
            {
                valor = "Y1AB";
            }
            else if (perfil.Contains("FRIMEDA 5.0Tn"))
            {
                valor = "Y1AD";
            }
            else if (perfil.Contains("FRIMEDA 7.5Tn"))
            {
                valor = "Y1AE";
            }
            else if (perfil.Contains("FRIMEDA 10Tn"))
            {
                valor = "Y1A8";
            }
            else if (perfil.Contains("FRIMEDA 12.5Tn"))
            {
                valor = "Y1A9";
            }
            else if (perfil.Contains("FRIMEDA 17Tn"))
            {
                valor = "Y1AA";
            }
            else if (perfil.Contains("FRIMEDA 22Tn"))
            {
                valor = "Y1AC";
            }

            else if (perfil.Contains("PFEIFER PLACA 0.5Tn"))
            {
                valor = "Y1A0";
            }
            else if (perfil.Contains("PFEIFER PLACA 1.2Tn"))
            {
                valor = "Y1A1";
            }
            else if (perfil.Contains("PFEIFER PLACA 2.5Tn"))
            {
                valor = "Y1A2";
            }
            else if (perfil.Contains("PFEIFER PLACA 4.0Tn"))
            {
                valor = "Y1A3";
            }
            else if (perfil.Contains("PFEIFER PLACA 6.3Tn"))
            {
                valor = "Y1A4";
            }
            else if (perfil.Contains("PFEIFER PLACA 8.0Tn"))
            {
                valor = "Y1A5";
            }
            else if (perfil.Contains("PFEIFER PLACA 12.5Tn"))
            {
                valor = "Y1A6";
            }

            else if (perfil.Contains("PFEIFER WAVED-S 1.2Tn"))
            {
                valor = "Y7R4";
            }
            else if (perfil.Contains("PFEIFER WAVED-S 2.0Tn"))
            {
                valor = "Y7RA";
            }
            else if (perfil.Contains("PFEIFER WAVED-S 2.5Tn"))
            {
                valor = "Y7R8";
            }

            else if (perfil.Contains("PFEIFER WAVED-L 0.5Tn"))
            {
                valor = "Y19T";
            }

            else if (perfil.Contains("PFEIFER WAVED-L 1.2Tn"))
            {
                valor = "Y19U";
            }
            else if (perfil.Contains("PFEIFER WAVED-L 2.0Tn"))
            {
                valor = "Y2A0";
            }
            else if (perfil.Contains("PFEIFER WAVED-L 2.5Tn"))
            {
                valor = "Y19W";
            }
            else if (perfil.Contains("PFEIFER WAVED-L 4.0Tn"))
            {
                valor = "Y19X";
            }
            else if (perfil.Contains("PFEIFER WAVED-L 6.3Tn"))
            {
                valor = "Y19Y";
            }
            else if (perfil.Contains("PFEIFER WAVED-L 8.0Tn"))
            {
                valor = "Y19Z";
            }
            else if (perfil.Contains("PFEIFER WAVED-L 12.5Tn"))
            {
                valor = "Y19V";
            }



            if (!valor.Equals(""))
                mainPart.SetUserProperty("PRODUCT_CODE", valor);
            mainPart.SetUserProperty("PRODUCT_UNIT", "ud");


            //mainPart.Modify();


            return valor;
        }

        public static string CodigoProductoPeikkoHalfen(string perfil, Part mainPart)
        {
            string valor = "";

            if (perfil.Contains("HCC 16-640"))
            {
                valor = "Y1FU";
            }
            else if (perfil.Contains("HCC 20-830"))
            {
                valor = "Y1FV";
            }
            else if (perfil.Contains("HCC 24-905"))
            {
                valor = "Y1FW";
            }
            else if (perfil.Contains("HCC 30-1100"))
            {
                valor = "Y1FX";
            }
            else if (perfil.Contains("HCC 39-1450"))
            {
                valor = "Y1FY";
            }
            else if (perfil.Contains("HCC M30-1200"))
            {
                valor = "Y1FZ";
            }
            else if (perfil.Contains("HCC M36-1650"))
            {
                valor = "Y1G0";
            }
            else if (perfil.Contains("HCC M39-1650"))
            {
                valor = "Y1G1";
            }
            else if (perfil.Contains("HCC M45-2070"))
            {
                valor = "Y1G2";
            }
            else if (perfil.Contains("HCC M52-2290"))
            {
                valor = "Y1G3";
            }



            else if (perfil.Contains("HAB H16-280"))
            {
                valor = "Y1G4";
            }
            else if (perfil.Contains("HAB H20-350"))
            {
                valor = "Y1G5";
            }
            else if (perfil.Contains("HAB H24-430"))
            {
                valor = "Y1G6";
            }
            else if (perfil.Contains("HAB H30-500"))
            {
                valor = "Y1G7";
            }
            else if (perfil.Contains("HAB H39-700"))
            {
                valor = "Y1G8";
            }
            else if (perfil.Contains("HAB S16-970"))
            {
                valor = "Y1GJ";
            }
            else if (perfil.Contains("HAB S20-1170"))
            {
                valor = "Y1GK";
            }
            else if (perfil.Contains("HAB S24-1360"))
            {
                valor = "Y1GL";
            }
            else if (perfil.Contains("HAB S30-1660"))
            {
                valor = "Y1GM";
            }
            else if (perfil.Contains("HAB S39-1979"))
            {
                valor = "Y1GN";
            }
            else if (perfil.Contains("HAB MH 30-755"))
            {
                valor = "Y1G9";
            }
            else if (perfil.Contains("HAB MH 36-755"))
            {
                valor = "Y1GA";
            }
            else if (perfil.Contains("HAB MH 39-880"))
            {
                valor = "Y1GB";
            }
            else if (perfil.Contains("HAB MH 45-980"))
            {
                valor = "Y1GC";
            }
            else if (perfil.Contains("HAB MH 52-1160"))
            {
                valor = "Y1GD";
            }
            else if (perfil.Contains("HAB MS 30-1400"))
            {
                valor = "Y1GE";
            }
            else if (perfil.Contains("HAB MS 36-1430"))
            {
                valor = "Y1GF";
            }
            else if (perfil.Contains("HAB MS 39-1600"))
            {
                valor = "Y1GG";
            }
            else if (perfil.Contains("HAB MS 45-1800"))
            {
                valor = "Y1GH";
            }
            else if (perfil.Contains("HAB MS 52-1910"))
            {
                valor = "Y1GI";
            }



            else if (perfil.Contains("PPM30L"))
            {
                valor = "Y1ET";
            }
            else if (perfil.Contains("PPM30P"))
            {
                valor = "Y1EU";
            }
            else if (perfil.Contains("PPM36L"))
            {
                valor = "Y1EV";
            }
            else if (perfil.Contains("PPM36P"))
            {
                valor = "Y1EW";
            }
            else if (perfil.Contains("PPM39L"))
            {
                valor = "Y1EX";
            }
            else if (perfil.Contains("PPM39P"))
            {
                valor = "Y1EY";
            }
            else if (perfil.Contains("PPM45L"))
            {
                valor = "Y1EZ";
            }
            else if (perfil.Contains("PPM45P"))
            {
                valor = "Y1F0";
            }
            else if (perfil.Contains("PPM52L"))
            {
                valor = "Y1F1";
            }
            else if (perfil.Contains("PPM52P"))
            {
                valor = "Y1F2";
            }


            else if (perfil.Contains("HPM16L"))
            {
                valor = "Y1EJ";
            }
            else if (perfil.Contains("HPM16P"))
            {
                valor = "Y1EK";
            }
            else if (perfil.Contains("HPM20L"))
            {
                valor = "Y1EL";
            }
            else if (perfil.Contains("HPM20P"))
            {
                valor = "Y1EM";
            }
            else if (perfil.Contains("HPM24L"))
            {
                valor = "Y1EN";
            }
            else if (perfil.Contains("HPM24P"))
            {
                valor = "Y1EO";
            }
            else if (perfil.Contains("HPM30L"))
            {
                valor = "Y1EP";
            }
            else if (perfil.Contains("HPM30P"))
            {
                valor = "Y1EQ";
            }
            else if (perfil.Contains("HPM39L"))
            {
                valor = "Y1ER";
            }
            else if (perfil.Contains("HPM39P"))
            {
                valor = "Y1ES";
            }



            else if (perfil.Contains("HPKM16"))
            {
                valor = "";
            }
            else if (perfil.Contains("HPKM20"))
            {
                valor = "Y1EA";
            }
            else if (perfil.Contains("HPKM24"))
            {
                valor = "Y1EB";
            }
            else if (perfil.Contains("HPKM30"))
            {
                valor = "Y1EC";
            }
            else if (perfil.Contains("HPKM39"))
            {
                valor = "Y1ED";
            }

            else if (perfil.Contains("PEC 30"))
            {
                valor = "Y1EE";
            }
            else if (perfil.Contains("PEC 36"))
            {
                valor = "Y1EF";
            }
            else if (perfil.Contains("PEC 39"))
            {
                valor = "Y1EG";
            }
            else if (perfil.Contains("PEC 45"))
            {
                valor = "Y1EH";
            }
            else if (perfil.Contains("PEC 52"))
            {
                valor = "Y1EI";
            }

            else if (perfil.Contains("BECO 16H"))
            {
                valor = "Y1EL";
            }
            else if (perfil.Contains("BECO 20H"))
            {
                valor = "Y1EM";
            }
            else if (perfil.Contains("BECO 24H"))
            {
                valor = "Y1EN";
            }
            else if (perfil.Contains("BECO 30H"))
            {
                valor = "Y1EP";
            }
            else if (perfil.Contains("BECO 30P"))
            {
                valor = "Y1ER";
            }
            
            else if (perfil.Contains("BECO 36P"))
            {
                valor = "Y1ES";
            }
            else if (perfil.Contains("BECO 39H"))
            {
                valor = "Y1EQ";
            }
            else if (perfil.Contains("BECO 39P"))
            {
                valor = "Y1ET";
            }
            else if (perfil.Contains("BECO 45P"))
            {
                valor = "Y1EU";
            }
            else if (perfil.Contains("BECO 52P"))
            {
                valor = "Y1EV";
            }
            







           



            else if (perfil.Contains("BOLDA 30"))
            {
                valor = "Y1EW";
            }
            else if (perfil.Contains("BOLDA 36"))
            {
                valor = "Y1EX";
            }
            else if (perfil.Contains("BOLDA 39"))
            {
                valor = "Y1EY";
            }
            else if (perfil.Contains("BOLDA 45"))
            {
                valor = "Y1EZ";
            }
            else if (perfil.Contains("BOLDA 52"))
            {
                valor = "Y1F0";
            }


            else if (perfil.Contains("SUMO 16H"))
            {
                valor = "Y6F1";
            }
            else if (perfil.Contains("SUMO 20H"))
            {
                valor = "Y6F2";
            }
            else if (perfil.Contains("SUMO 24H"))
            {
                valor = "Y6F3";
            }
            else if (perfil.Contains("SUMO 30H"))
            {
                valor = "Y6F4";
            }
            else if (perfil.Contains("SUMO 30P"))
            {
                valor = "Y6F7";
            }

            else if (perfil.Contains("SUMO 36P"))
            {
                valor = "Y6F8";
            }
            else if (perfil.Contains("SUMO 39H"))
            {
                valor = "Y6F5";
            }
            else if (perfil.Contains("SUMO 39P"))
            {
                valor = "Y6F9";
            }
            else if (perfil.Contains("SUMO 45P"))
            {
                valor = "Y6FA";
            }
            else if (perfil.Contains("SUMO 52P"))
            {
                valor = "Y6FB";
            }



            if (!valor.Equals(""))
                mainPart.SetUserProperty("PRODUCT_CODE", valor);
            mainPart.SetUserProperty("PRODUCT_UNIT", "ud");


            //mainPart.Modify();


            return valor;
        }

        public static string CodigoProductoLineales(string perfil, Part mainPart)
        {
            string valor = "";

            if (perfil.Contains("Ø30-39"))
            {
                valor = "Y1B1";
            }
            else if (perfil.Contains("Ø39-45"))
            {
                valor = "Y1B2";
            }
            
            else if (perfil.Contains("Ø51-57"))
            {
                valor = "Y1B3";
            }
            else if (perfil.Contains("Ø63-69"))
            {
                valor = "Y1B4";
            }
            else if (perfil.Contains("Ø75-81"))
            {
                valor = "Y1B5";
            }
            else if (perfil.Contains("Ø81-87"))
            {
                valor = "Y1B6";
            }
            else if (perfil.Contains("Ø90-99"))
            {
                valor = "Y1B7";
            }
            else if (perfil.Contains("Ø100-109"))
            {
                valor = "Y1AY";
            }
            else if (perfil.Contains("Ø110-119"))
            {
                valor = "Y1AZ";
            }
            else if (perfil.Contains("Ø120-129"))
            {
                valor = "Y1B0";
            }
            else if (perfil.Contains("Ø130-139"))
            {
                valor = "Y1B8";
            }
            else if (perfil.Contains("Ø140-149"))
            {
                valor = "Y1B9";
            }
            else if (perfil.Contains("Ø160-169"))
            {
                valor = "Y1BA";
            }


            else if (perfil.Contains("TUBO PVC 40"))
            {
                valor = "Y1BN";
            }
            else if (perfil.Contains("TUBO PVC 50"))
            {
                valor = "Y1BO";
            }
            else if (perfil.Contains("TUBO PVC 75"))
            {
                valor = "Y1BP";
            }
            else if (perfil.Contains("TUBO PVC 90"))
            {
                valor = "Y1BQ";
            }
            else if (perfil.Contains("TUBO PVC 110"))
            {
                valor = "Y1BR";
            }
            else if (perfil.Contains("TUBO PVC 125"))
            {
                valor = "Y1BS";
            }
            else if (perfil.Contains("TUBO PVC 160"))
            {
                valor = "Y1BT";
            }
            else if (perfil.Contains("TUBO PVC 200"))
            {
                valor = "Y1BU";
            }
            else if (perfil.Contains("TUBO PVC 250"))
            {
                valor = "Y1BV";
            }
            else if (perfil.Contains("TUBO PVC 315"))
            {
                valor = "Y1BW";
            }



            else if (perfil.Contains("PVC40"))
            {
                valor = "Y1BN";
            }
            else if (perfil.Contains("PVC50"))
            {
                valor = "Y1BO";
            }
            else if (perfil.Contains("PVC75"))
            {
                valor = "Y1BP";
            }
            else if (perfil.Contains("PVC90"))
            {
                valor = "Y1BQ";
            }
            else if (perfil.Contains("PVC110"))
            {
                valor = "Y1BR";
            }
            else if (perfil.Contains("PVC125"))
            {
                valor = "Y1BS";
            }
            else if (perfil.Contains("PVC160"))
            {
                valor = "Y1BT";
            }
            else if (perfil.Contains("PVC200"))
            {
                valor = "Y1BU";
            }
            else if (perfil.Contains("PVC250"))
            {
                valor = "Y1BV";
            }
            else if (perfil.Contains("PVC315"))
            {
                valor = "Y1BW";
            }






            if (mainPart.Name.Contains("BANDA"))
                {

            

            if (perfil.Contains("60.6") || perfil.Contains("60*6") || perfil.Contains("6*60"))
            {
                valor = "Y1CE";
            }
            else if (perfil.Contains("100.10") || perfil.Contains("100*10") || perfil.Contains("10*100"))
            {
                valor = "Y1CF";
            }
            else if (perfil.Contains("150.10") || perfil.Contains("150*10") || perfil.Contains("10*150"))
            {
                valor = "Y1CG";
            }
            else if (perfil.Contains("100.6") || perfil.Contains("100*6") || perfil.Contains("6*100"))
            {
                valor = "Y6EH";
            }
            else if (perfil.Contains("50.6") || perfil.Contains("50*6") || perfil.Contains("6*50"))
            {
                valor = "Y6EG";
            }
            else if (perfil.Contains("70.10") || perfil.Contains("70*10") || perfil.Contains("10*70"))
            {
                valor = "Y6RC";
            }
            }

            if (!valor.Equals(""))
                mainPart.SetUserProperty("PRODUCT_CODE", valor);
            
            
            mainPart.SetUserProperty("PRODUCT_UNIT", "ml");


            //mainPart.Modify();


            return valor;
        }


    }
}
