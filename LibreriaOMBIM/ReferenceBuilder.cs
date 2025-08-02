using System;
using System.Collections;
using System.Windows.Forms;
using Tekla.Structures.Dialog;
using Tekla.Structures.Dialog.UIControls;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using TSMUI = Tekla.Structures.Model.UI;


namespace LibreriaOMBIM
{
    public sealed class ReferenceBuilder
    {
        public static PolygonWeld CrearSoldadura(Part primary, Part secondary, bool subConjunto, bool taller)
        {
            Part p1 = primary as Part;
            Part p = secondary as Part;

            Solid solid = p1.GetSolid();


            Polygon pol = new Polygon();
            pol.Points.Add(new Point(solid.MinimumPoint));
            pol.Points.Add(new Point(solid.MaximumPoint));



            PolygonWeld weld = new PolygonWeld();
            weld.MainObject = p1;
            weld.SecondaryObject = p;
            weld.TypeAbove = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;
            weld.TypeBelow = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;
            weld.AroundWeld = false;

            weld.ConnectAssemblies = subConjunto;
            weld.ShopWeld = taller;
            weld.Polygon = pol;

            weld.Insert();
            weld.SizeBelow = 0.0;
            weld.SizeAbove = 0.0;
            weld.Modify();
            return weld;
        }

        public static PolygonWeld AddParteSubconjuntoFabricacion(Part primary, Part secondary)
        {
            Part p1 = primary as Part;
            Part p = secondary as Part;

            Solid solid = p.GetSolid();

            Polygon pol = new Polygon();
            pol.Points.Add(new Point(solid.MinimumPoint));
            pol.Points.Add(new Point(solid.MaximumPoint));


            PolygonWeld weld = new PolygonWeld();
            weld.MainObject = p1;
            weld.SecondaryObject = p;
            //weld.TypeAbove = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;
            //weld.TypeBelow = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;
            //weld.AroundWeld = false;

            weld.ConnectAssemblies = true;
            weld.ShopWeld = true;
            weld.Polygon = pol;

            weld.Insert();
            //weld.SizeBelow = 0.0;
            weld.SizeAbove = 0.0;
            weld.Modify();
            return weld;
        }

        public static PolygonWeld AddParteSecundariaFabricacion(Part primary, Part secondary)
        {
            Part p1 = primary as Part;
            Part p = secondary as Part;

            Solid solid = p.GetSolid();


            Polygon pol = new Polygon();
            pol.Points.Add(new Point(solid.MinimumPoint));
            pol.Points.Add(new Point(solid.MaximumPoint));


            PolygonWeld weld = new PolygonWeld();
            weld.MainObject = p1;
            weld.SecondaryObject = p;
            //weld.TypeAbove = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;
            //weld.TypeBelow = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;
            //weld.AroundWeld = false;

            weld.ConnectAssemblies = false;
            weld.ShopWeld = true;
            weld.Polygon = pol;

            weld.Insert();
            //weld.SizeBelow = 0.0;
            weld.SizeAbove = 0.0;
            weld.Modify();
            return weld;
        }

        public static PolygonWeld AddParteMontaje(Part primary, Part secondary)
        {
            Assembly assembly = secondary.GetAssembly();

            Part p1 = primary as Part;
            Part p2 = secondary as Part;

            Solid solid = p2.GetSolid();

            Polygon pol = new Polygon();
            pol.Points.Add(new Point(solid.MinimumPoint));
            pol.Points.Add(new Point(solid.MaximumPoint));

            PolygonWeld weld = new PolygonWeld();
            weld.MainObject = p2;
            weld.SecondaryObject = p1;
            //weld.TypeAbove = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;
            //weld.TypeBelow = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;
            //weld.AroundWeld = false;

            weld.ConnectAssemblies = false;
            weld.ShopWeld = false;
            weld.Polygon = pol;

            weld.Insert();
            //weld.SizeBelow = 1.0;
            weld.SizeAbove = 0.0;
            weld.Modify();
            return weld;
        }

        public static PolygonWeld AddParteFabricacionNoNumeracion(Part primary, Part secondary)
        {
            Part p1 = primary as Part;
            Part p2 = secondary as Part;

            Solid solid = p2.GetSolid();


            Polygon pol = new Polygon();
            pol.Points.Add(new Point(solid.MinimumPoint));
            pol.Points.Add(new Point(solid.MaximumPoint));



            PolygonWeld weld = new PolygonWeld();
            weld.MainObject = p1;
            weld.SecondaryObject = p2;
            weld.TypeAbove = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;
            weld.TypeBelow = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;
            weld.AroundWeld = false;

            weld.ConnectAssemblies = false;
            weld.ShopWeld = false;
            weld.Polygon = pol;

            weld.Insert();
            weld.SizeBelow = 0.0;
            weld.SizeAbove = 0.0;
            weld.Modify();
            return weld;
        }



        public static Assembly CrearConjuntoMontaje(ArrayList subassemblyList, Part part)
        {
            //Beam dummyPart = new Beam();
            //dummyPart.StartPoint = new Tekla.Structures.Geometry3d.Point(0, 0);
            //dummyPart.EndPoint = new Tekla.Structures.Geometry3d.Point(0, 10);
            //dummyPart.Profile.ProfileString = "0*0";
            //dummyPart.Insert();

            //Assembly subassemblyBeam = dummyPart.GetAssembly();

            //foreach (Part a in subassemblyList)
            //{
            //    //a.SetUserProperty("comment", "MONTAJE");
            //    //a.Modify();
            //    Assembly assemblyModify = a.GetAssembly();
            //    subassemblyBeam.Add(assemblyModify);
            //}
            //if (subassemblyBeam.Modify())
            //{
            //    //Console.WriteLine("Assembly Modify Failed!");

            //    foreach (Part a in subassemblyList)
            //    {
            //        CrearSoldadura(a, part, false, false);
            //    }
            //}

            //dummyPart.Delete();

            //return subassemblyBeam;
            Beam dummyPart = new Beam();
            dummyPart.StartPoint = new Tekla.Structures.Geometry3d.Point(0, 0);
            dummyPart.EndPoint = new Tekla.Structures.Geometry3d.Point(0, 10);
            dummyPart.Profile.ProfileString = "0*0";
            dummyPart.Insert();


            Assembly subassemblyBeam = dummyPart.GetAssembly();

            foreach (Part a in subassemblyList)
            {
                ReferenceBuilder.AddParteMontaje(part, a);

                Assembly assemblyModify = a.GetAssembly();
                subassemblyBeam.Add(assemblyModify);
            }




            dummyPart.Delete();

            return subassemblyBeam;
        }

        public static Assembly CrearConjuntoMontaje(ArrayList subassemblyList, Part part, string nombreGrupo, string prefijoGrupo)
        {
            Beam dummyPart = new Beam();
            dummyPart.StartPoint = new Tekla.Structures.Geometry3d.Point(0, 0);
            dummyPart.EndPoint = new Tekla.Structures.Geometry3d.Point(0, 10);
            dummyPart.Profile.ProfileString = "0*0";
            dummyPart.Insert();

            dummyPart.SetUserProperty("ERECTION_CODE", prefijoGrupo);
            dummyPart.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
            dummyPart.Modify();


            Assembly subassemblyBeam = dummyPart.GetAssembly();

            foreach (Part a in subassemblyList)
            {
                AddParteMontaje(part, a);
                subassemblyBeam.Add(a);
            }

            subassemblyBeam.Name = nombreGrupo;
            subassemblyBeam.AssemblyNumber.Prefix = prefijoGrupo;

            if (!subassemblyBeam.Modify())
                Console.WriteLine("Assembly Modify Failed!");

            dummyPart.Delete();

            return subassemblyBeam;
        }
        public static Assembly CrearConjuntoMontaje2(ArrayList subassemblyList, Part part, string nombreGrupo, string prefijoGrupo)
        {
            Assembly subassemblyBeam = part.GetAssembly();
            if (subassemblyList.Count > 1)
            {
                foreach (Part a in subassemblyList)
                {
                    ReferenceBuilder.AddParteSecundariaFabricacion(part, a);
                }
            }
            subassemblyBeam.Name = nombreGrupo;
            subassemblyBeam.AssemblyNumber.Prefix = prefijoGrupo;

            if (!subassemblyBeam.Modify())
                Console.WriteLine("Assembly Modify Failed!");


            return subassemblyBeam;
        }

        public static Assembly CrearConjuntoCimentacion(ArrayList subassemblyList, Part part, string nombreGrupo, string prefijoGrupo)
        {
            Beam dummyPart = new Beam();
            dummyPart.StartPoint = new Tekla.Structures.Geometry3d.Point(0, 0);
            dummyPart.EndPoint = new Tekla.Structures.Geometry3d.Point(0, 10);
            dummyPart.Profile.ProfileString = "0*0";
            //dummyPart.Material.MaterialString = "HA-40";
            dummyPart.Insert();

            dummyPart.SetUserProperty("ERECTION_CODE", prefijoGrupo);
            dummyPart.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
            dummyPart.Modify();


            Assembly subassemblyBeam = dummyPart.GetAssembly();

            foreach (Part a in subassemblyList)
            {
                AddParteMontaje(part, a);

                subassemblyBeam.Add(a);
            }
            subassemblyBeam.Name = nombreGrupo;
            subassemblyBeam.AssemblyNumber.Prefix = prefijoGrupo;

            if (!subassemblyBeam.Modify())
                Console.WriteLine("Assembly Modify Failed!");

            dummyPart.Delete();

            return subassemblyBeam;
        }
        public static Assembly CrearConjuntoCimentacion2(ArrayList subassemblyList, Part part, string nombreGrupo, string prefijoGrupo)
        {
            Assembly subassemblyBeam = part.GetAssembly();
            if (subassemblyList.Count > 1)
            {
                foreach (Part a in subassemblyList)
                {
                    ReferenceBuilder.AddParteSecundariaFabricacion(part, a);

                }
            }
            int cuenta = 0;
            for (int i = 0; i < subassemblyList.Count; i++)
            {
                if (cuenta == 0)
                {
                    Part part1 = subassemblyList[i] as Part;
                    string material = "";
                    part1.GetReportProperty("MATERIAL_TYPE", ref material);
                    if (material == "CONCRETE")
                    {
                        subassemblyBeam.SetMainPart(part1);
                        cuenta++;
                    }
                }
            }
            subassemblyBeam.Name = nombreGrupo;
            subassemblyBeam.AssemblyNumber.Prefix = prefijoGrupo;

            if (!subassemblyBeam.Modify())
                Console.WriteLine("Assembly Modify Failed!");


            return subassemblyBeam;
        }

        public static Assembly CrearConjuntoFabricacion(ArrayList subassemblyList, Part part)
        {
            Assembly subassemblyBeam = part.GetAssembly();

            foreach (Part a in subassemblyList)
            {
                ReferenceBuilder.AddParteSecundariaFabricacion(part, a);
            }
            subassemblyBeam.Name = part.Name;
            subassemblyBeam.AssemblyNumber.Prefix = part.AssemblyNumber.Prefix;
            subassemblyBeam.AssemblyNumber.StartNumber = 1;

            if (!subassemblyBeam.Modify())
                Console.WriteLine("Assembly Modify Failed!");

            return subassemblyBeam;
        }
        public static Assembly CrearConjuntoFabricacion(ArrayList subassemblyList, Part part, string nombreGrupo, string prefijoGrupo)
        {
            Assembly subassemblyBeam = part.GetAssembly();
            if (subassemblyList.Count > 1)
            {
                foreach (Part a in subassemblyList)
                {
                    ReferenceBuilder.AddParteSecundariaFabricacion(part, a);
                }
            }
            subassemblyBeam.Name = nombreGrupo;
            subassemblyBeam.AssemblyNumber.Prefix = prefijoGrupo;
            subassemblyBeam.AssemblyNumber.StartNumber = 1;

            if (!subassemblyBeam.Modify())
                Console.WriteLine("Assembly Modify Failed!");

            return subassemblyBeam;
        }



        public static void CrearGrupoCimentacion(ArrayList subassemblyList, Part primaryAssemblyPart, Part primaryPart, string nombreGrupo, string prefijoGrupo)
        {
            ReferenceBuilder.AddParteMontaje(primaryPart, primaryAssemblyPart);

            ReferenceBuilder.CrearConjuntoCimentacion2(subassemblyList, primaryAssemblyPart, nombreGrupo, prefijoGrupo);

        }

        public static void CrearGrupoMontaje(ArrayList subassemblyList, Part primaryAssemblyPart, Part primaryPart, string nombreGrupo, string prefijoGrupo)
        {
            //ReferenceBuilder.AddParteMontaje(primaryPart, primaryAssemblyPart);

            ReferenceBuilder.assemblyMontaje(subassemblyList, primaryPart, nombreGrupo, prefijoGrupo);


        }

        public static void CrearGrupoFabricacion(ArrayList subassemblyList, Part primaryAssemblyPart, Part primaryPart, string nombreGrupo, string prefijoGrupo)
        {
            ReferenceBuilder.AddParteSubconjuntoFabricacion(primaryPart, primaryAssemblyPart);

            ReferenceBuilder.CrearConjuntoFabricacion(subassemblyList, primaryAssemblyPart, nombreGrupo, prefijoGrupo);

        }
        public static void CrearGrupoFabricacionSubAssemblies(ArrayList subassemblyList, Part primaryAssemblyPart, Part primaryPart, string nombreGrupo, string prefijoGrupo)
        {

            ReferenceBuilder.assemblyFabricacion(subassemblyList, primaryPart, primaryAssemblyPart, nombreGrupo, prefijoGrupo);
            //ReferenceBuilder.AddParteSubconjuntoFabricacion(primaryPart, primaryAssemblyPart);

        }


        public static Assembly assemblyMontaje(ArrayList subassemblyList, Part part, string nombreGrupo, string prefijoGrupo)
        {
            string idPrincipal = part.GetAssembly().Identifier.GUID.ToString();

            Beam dummyPart = new Beam();
            dummyPart.StartPoint = new Tekla.Structures.Geometry3d.Point(0, 0);
            dummyPart.EndPoint = new Tekla.Structures.Geometry3d.Point(0, 10);
            dummyPart.Profile.ProfileString = "0*0";
            dummyPart.Insert();

            dummyPart.SetUserProperty("ERECTION_CODE", prefijoGrupo);
            dummyPart.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
            dummyPart.Modify();

            Assembly subassemblyBeam = dummyPart.GetAssembly();

            foreach (Part a in subassemblyList)
            {
                ReferenceBuilder.AddParteMontaje(part, a);

                Assembly assemblyModify = a.GetAssembly();
                subassemblyBeam.Add(assemblyModify);
            }

            subassemblyBeam.Name = nombreGrupo;
            subassemblyBeam.AssemblyNumber.Prefix = prefijoGrupo;
            subassemblyBeam.AssemblyNumber.StartNumber = 1;

            if (!subassemblyBeam.Modify())
                Console.WriteLine("Assembly Modify Failed!");

            dummyPart.Delete();

            return subassemblyBeam;
        }

        public static Assembly assemblyFabricacion(ArrayList subassemblyList, Part part, Part primaryAssemblyPart, string nombreGrupo, string prefijoGrupo)
        {
            //string idPrincipal = part.GetAssembly().Identifier.GUID.ToString();
            ReferenceBuilder.AddParteSubconjuntoFabricacion(part, primaryAssemblyPart);

            Beam dummyPart = new Beam();
            dummyPart.StartPoint = new Tekla.Structures.Geometry3d.Point(0, 0);
            dummyPart.EndPoint = new Tekla.Structures.Geometry3d.Point(0, 10);
            dummyPart.Profile.ProfileString = "0*0";
            //dummyPart.Name = nomGr;
            //dummyPart.AssemblyNumber.Prefix = PrefGr;
            dummyPart.Insert();
            dummyPart.SetUserProperty("comment", "FABRICACION");

            dummyPart.SetUserProperty("ERECTION_CODE", prefijoGrupo);
            dummyPart.SetUserProperty("ERECTION_COMMENT", nombreGrupo);
            dummyPart.Modify();

            //Assembly assemblyBeam = dummyPart.GetAssembly();
            //ArrayList newsubassemblyList = new ArrayList();

            //foreach (Part a in subassemblyList)
            //{
            //    string idSecondary = a.GetAssembly().Identifier.GUID.ToString();
            //    if (idPrincipal == idSecondary)
            //    {
            //        assemblyBeam.Add(a);
            //        newsubassemblyList.Add(a);
            //    }
            //}

            //if (!assemblyBeam.Modify())
            //    Console.WriteLine("Assembly Modify Failed!");
            //assemblyBeam.Delete();

            Assembly subassemblyBeam = primaryAssemblyPart.GetAssembly();
            //subassemblyBeam.Name = nombreGrupo;
            //subassemblyBeam.AssemblyNumber.Prefix = prefijoGrupo;
            //subassemblyBeam.AssemblyNumber.StartNumber = 1;


            //if (!subassemblyBeam.Modify())
            //    Console.WriteLine("Assembly Modify Failed!");
            foreach (Part a in subassemblyList)
            {
                ReferenceBuilder.AddParteSubconjuntoFabricacion(primaryAssemblyPart, a);

                Assembly assemblyModify = a.GetAssembly();

                //assemblyModify.Name = a.Name;
                //assemblyModify.AssemblyNumber.Prefix = a.AssemblyNumber.Prefix;
                //assemblyModify.AssemblyNumber.StartNumber = a.AssemblyNumber.StartNumber;

                //assemblyModify.Modify();

                //subassemblyBeam.Add(assemblyModify);

            }

            subassemblyBeam.Name = nombreGrupo;
            subassemblyBeam.AssemblyNumber.Prefix = prefijoGrupo;
            subassemblyBeam.AssemblyNumber.StartNumber = 1;
            subassemblyBeam.SetMainPart(primaryAssemblyPart);

            if (!subassemblyBeam.Modify())
                Console.WriteLine("Assembly Modify Failed!");


            //if (subassemblyList.Count == 1)
            //{
            //    subassemblyBeam.Delete();
            //}



            //Assembly assemblyModify2 = part.GetAssembly();
            //assemblyModify2.Add(subassemblyBeam);
            //if (!assemblyModify2.Modify())
            //    Console.WriteLine("Assembly Modify Failed!");
            dummyPart.Delete();


            return subassemblyBeam;
        }


        public static Assembly creaConjunto(ArrayList subassemblyList, string nombreGrupo, string prefijoGrupo)
        {
            //Part part = subassemblyList[0] as Part;
            Beam dummyPart = new Beam();
            dummyPart.StartPoint = new Tekla.Structures.Geometry3d.Point(0, 0);
            dummyPart.EndPoint = new Tekla.Structures.Geometry3d.Point(0, 10);
            dummyPart.Profile.ProfileString = "0*0";
            dummyPart.Insert();

            Assembly subassemblyBeam = dummyPart.GetAssembly();
            foreach (Part a in subassemblyList)
            {
                Assembly assemblyModify = a.GetAssembly();
                subassemblyBeam.Add(assemblyModify);
            }

            subassemblyBeam.Name = nombreGrupo;
            subassemblyBeam.AssemblyNumber.Prefix = prefijoGrupo;
            subassemblyBeam.AssemblyNumber.StartNumber = 1;

            if (!subassemblyBeam.Modify())
                Console.WriteLine("Assembly Modify Failed!");

            dummyPart.Delete();


            return subassemblyBeam;
        }


        public static void Ejes(Point p, string perfil, double LongEje)
        {
            Beam X = new Beam(new Point(p), new Point(p.X + LongEje, p.Y, p.Z));
            X.Profile.ProfileString = perfil;
            X.Class = "2";
            X.Insert();
            Beam Y = new Beam(new Point(p), new Point(p.X, p.Y + LongEje, p.Z));
            Y.Profile.ProfileString = perfil;
            Y.Class = "3";
            Y.Insert();
            Beam Z = new Beam(new Point(p), new Point(p.X, p.Y, p.Z + LongEje));
            Z.Profile.ProfileString = perfil;
            Z.Class = "4";
            Z.Insert();
        }
        public static void RedrawAllsView()
        {
            Model Model = new Model();

            TSMUI.ModelViewEnumerator TheseViews = TSMUI.ViewHandler.GetAllViews();
            TSMUI.View ThisView = null;
            if (TheseViews.Count == 0)
            {
                TheseViews = TSMUI.ViewHandler.GetVisibleViews();
                if (TheseViews.Count > 0)
                {
                    TheseViews.MoveNext();
                    ThisView = TheseViews.Current as TSMUI.View;
                }
            }
            else
            {
                TheseViews.MoveNext();
                ThisView = TheseViews.Current as TSMUI.View;
            }

            if (ThisView != null)
            {
                TSMUI.ViewHandler.RedrawView(ThisView);
            }
        }

        public static void DrawLine(LineSegment lineSegment, Tekla.Structures.Model.UI.Color color)
        {
            GraphicsDrawer.DrawLineSegment(lineSegment, color);

        }

        public static void DrawText(Point point, string text, Tekla.Structures.Model.UI.Color color)
        {
            GraphicsDrawer.DrawText(point, text, color);

        }

        private static Tekla.Structures.Model.UI.GraphicsDrawer GraphicsDrawer = new Tekla.Structures.Model.UI.GraphicsDrawer();
        private readonly static Tekla.Structures.Model.UI.Color TextColor = new Tekla.Structures.Model.UI.Color(1, 0, 1);

        //Draws the coordinate system in which the values are shown
        public static void DrawCoordinateSytem(CoordinateSystem CoordinateSystem)
        {
            DrawVector(CoordinateSystem.Origin, CoordinateSystem.AxisX, "X", new Tekla.Structures.Model.UI.Color(0, 1, 1));
            DrawVector(CoordinateSystem.Origin, CoordinateSystem.AxisY, "Y", new Tekla.Structures.Model.UI.Color(0, 1, 1));
        }

        //Draws the vector of the coordinate system
        private static void DrawVector(Point StartPoint, Vector Vector, string Text, Tekla.Structures.Model.UI.Color color)
        {
            const double Radians = 0.43;

            Vector = Vector.GetNormal();
            Vector Arrow01 = new Vector(Vector);

            Vector.Normalize(500);
            Point EndPoint = new Point(StartPoint);
            EndPoint.Translate(Vector.X, Vector.Y, Vector.Z);
            GraphicsDrawer.DrawLineSegment(StartPoint, EndPoint, color);

            GraphicsDrawer.DrawText(EndPoint, Text, color);

            Arrow01.Normalize(-100);
            Vector Arrow = ArrowVector(Arrow01, Radians);

            Point ArrowExtreme = new Point(EndPoint);
            ArrowExtreme.Translate(Arrow.X, Arrow.Y, Arrow.Z);
            GraphicsDrawer.DrawLineSegment(EndPoint, ArrowExtreme, color);

            Arrow = ArrowVector(Arrow01, -Radians);

            ArrowExtreme = new Point(EndPoint);
            ArrowExtreme.Translate(Arrow.X, Arrow.Y, Arrow.Z);
            GraphicsDrawer.DrawLineSegment(EndPoint, ArrowExtreme, color);
        }

        //Draws the arrows of the vectors
        private static Vector ArrowVector(Vector Vector, double Radians)
        {
            double X, Y, Z;

            if (Vector.X == 0 && Vector.Y == 0)
            {
                X = Vector.X;
                Y = (Vector.Y * Math.Cos(Radians)) - (Vector.Z * Math.Sin(Radians));
                Z = (Vector.Y * Math.Sin(Radians)) + (Vector.Z * Math.Cos(Radians));
            }
            else
            {
                X = (Vector.X * Math.Cos(Radians)) - (Vector.Y * Math.Sin(Radians));
                Y = (Vector.X * Math.Sin(Radians)) + (Vector.Y * Math.Cos(Radians));
                Z = Vector.Z;
            }

            return new Vector(X, Y, Z);
        }

        public static void DrawCoordinateSytem(CoordinateSystem CoordinateSystem, Tekla.Structures.Model.UI.Color color)
        {
            DrawVector(CoordinateSystem.Origin, CoordinateSystem.AxisX, "X",color);
            DrawVector(CoordinateSystem.Origin, CoordinateSystem.AxisY, "Y",color);
        }

        public static void Form_LoadValues(Control frm)
        {
            
            //frm.FindForm();
            RecControles(frm);
            //FormBase formBase = frm as FormBase;
            //foreach (Control ctrls in formBase.Controls)
            //{
            //    if (ctrls is Tekla.Structures.Dialog.UIControls.SaveLoad)
            //    {

            //        foreach (Control ctrl in ctrls.Controls)
            //        {


            //            foreach (Control ctrl2 in ctrl.Controls)
            //            {

            //                if (ctrl2 is Button)
            //                {
            //                    Button button = ctrl2 as Button;
            //                    if (button.Name.Equals("saveButton"))
            //                    {
            //                        button.BackColor =System.Drawing.Color.Red;
            //                        button.FlatStyle = FlatStyle.Flat;
            //                        button.ForeColor = System.Drawing.Color.White;
            //                    }
            //                    else if (button.Name.Equals("loadButton"))
            //                    {
            //                        button.BackColor = System.Drawing.Color.Blue;
            //                        button.FlatStyle = FlatStyle.Flat;
            //                        button.ForeColor = System.Drawing.Color.White;
            //                    }
            //                    else if (button.Name.Equals("helpButton"))
            //                    {
            //                        button.BackColor = System.Drawing.Color.Black;
            //                        button.FlatStyle = FlatStyle.Flat;
            //                        button.ForeColor = System.Drawing.Color.White;
            //                    }

            //                }
            //            }
            //        }
            //    }


            //}
        }

        public static void RecControles(Control control)
        {
            //Recorremos con un ciclo for each cada control que hay en la colección Controls
            foreach (Control contHijo in control.Controls)
            {
                //Preguntamos si el control tiene uno o mas controles dentro del mismo con la propiedad 'HasChildren'
                //Si el control tiene 1 o más controles, entonces llamamos al procedimiento de forma recursiva, para que siga recorriendo los demás controles 
                if (contHijo.HasChildren) RecControles(contHijo);
                //Aqui va la lógica de lo queramos hacer, en mi ejemplo, voy a pintar de color azul el fondo de todos los controles

                if (contHijo is Button)
                {
                    try
                    {
                        Button button = contHijo as Button;
                        cambiaButton(button);



                    }
                    catch { }
                }

            }
        }

        public static void cambiaButton(Button button)
        {

            if (button.Name.Equals("saveButton"))
            {
                button.BackColor = System.Drawing.Color.IndianRed;
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = System.Drawing.Color.White;
            }
            else if (button.Name.Equals("loadButton"))
            {
                button.BackColor = System.Drawing.Color.SteelBlue;
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = System.Drawing.Color.White;
            }
            else if (button.Name.Equals("helpButton"))
            {
                button.BackColor = System.Drawing.Color.Black;
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = System.Drawing.Color.White;
            }
        }

    }
}
