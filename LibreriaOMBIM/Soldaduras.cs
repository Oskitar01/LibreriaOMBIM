using System.Collections;
using System.Windows.Forms;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace LibreriaOMBIM.Conjuntos
{
    public sealed class Soldaduras
    {
        public static PolygonWeld CrearSoldadura(Part colada, Part secondary)
        {
            Part p1 = colada as Part;
            Part p2 = secondary as Part;

            Solid solid = p2.GetSolid();

            Polygon pol = new Polygon();
            pol.Points.Add(new Point(solid.MinimumPoint));
            pol.Points.Add(new Point(solid.MaximumPoint));

            PolygonWeld weld = new PolygonWeld();
            weld.MainObject = p1;
            weld.SecondaryObject = p2;

            weld.Polygon = pol;
            weld.SizeAbove = 0.0;
            weld.AroundWeld = false;
            weld.TypeAbove = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;
            weld.TypeBelow = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;

            weld.Insert();
            weld.Modify();
            return weld;
        }

        public static void AddParteAColadaSubconjuntoObra(Part colada, Part secondary)
        {
            //LimpiaAssembly(secondary);

            //Assembly assembly = secondary.GetAssembly() as Assembly;
            //assembly.AssemblyNumber.Prefix = "";
            //assembly.AssemblyNumber.StartNumber = 0;
            //assembly.Name = secondary.Name;
            //assembly.Modify();


            PolygonWeld weld = CrearSoldadura(colada, secondary);

            weld.ConnectAssemblies = false;
            weld.ShopWeld = false;

            weld.Modify();


        }


        public static void AddParteAColadaSubconjuntoTaller(Part colada, Part secondary)
        {
            //LimpiaAssembly(secondary);

            //Assembly assembly = secondary.GetAssembly() as Assembly;
            //assembly.AssemblyNumber.Prefix = "";
            //assembly.AssemblyNumber.StartNumber = 0;
            //assembly.Name = secondary.Name;
            //assembly.Modify();


            PolygonWeld weld = CrearSoldadura(colada, secondary);
            weld.ConnectAssemblies = true;
            weld.ShopWeld = true;
            weld.Modify();
        }
        public static void AddParteAColadaSubconjuntoTallerLimpia(Part colada, Part secondary)
        {
            //LimpiaAssembly(secondary);

            Assembly assembly = secondary.GetAssembly() as Assembly;
            assembly.AssemblyNumber.Prefix = "";
            assembly.AssemblyNumber.StartNumber = 0;
            assembly.Name = secondary.Name;
            assembly.Modify();


            PolygonWeld weld = CrearSoldadura(colada, secondary);
            weld.ConnectAssemblies = true;
            weld.ShopWeld = true;
            weld.Modify();
        }

        public static void AddParteAColadaSubconjuntoTallerNoReNum(Part colada, Part secondary)
        {
            PolygonWeld weld = CrearSoldadura(colada, secondary);
            weld.ConnectAssemblies = true;
            weld.ShopWeld = true;
            weld.Modify();
        }


        public static PolygonWeld AddParteAParteSecundariaTaller(Part colada, Part secondary, string nomGrupo, string prefGrupo)
        {

            PolygonWeld weld = CrearSoldadura(colada, secondary);
            weld.ConnectAssemblies = false;
            weld.ShopWeld = true;
            weld.Modify();

            return weld;
        }

        public static PolygonWeld AddParteAParteSecundariaTaller(Part colada, Part secondary)
        {
            Part p1 = colada as Part;
            Part p2 = secondary as Part;

            Solid solid = p2.GetSolid();

            Polygon pol = new Polygon();
            pol.Points.Add(new Point(solid.MinimumPoint));
            pol.Points.Add(new Point(solid.MaximumPoint));

            PolygonWeld weld = new PolygonWeld();
            weld.MainObject = p1;
            weld.SecondaryObject = p2;


            weld.ConnectAssemblies = false;
            weld.ShopWeld = true;
            weld.Polygon = pol;
            weld.AroundWeld = false;
            weld.TypeAbove = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;
            weld.TypeBelow = BaseWeld.WeldTypeEnum.WELD_TYPE_NONE;

            weld.Insert();
            weld.SizeAbove = 0.0;
            weld.Modify();

            return weld;
        }

        public static Weld AddParteAParteSecundariaTallerAcero(Part primary, Part secondary, Weld.WeldPositionEnum weldPositionEnum)
        {
            Part p1 = primary as Part;
            Part p2 = secondary as Part;


            Weld weld = new Weld();
            weld.MainObject = p1;
            weld.SecondaryObject = p2;

            weld.AroundWeld = false;
            weld.ConnectAssemblies = false;
            weld.ShopWeld = true;
            weld.Position = weldPositionEnum;
            weld.Insert();
            weld.SizeAbove = 3.0;
            weld.Modify();

            return weld;
        }


        public static void AddPartesSueltasAParteTaller(ArrayList listAssemblies, Part Parte)
        {
            foreach (Part part in listAssemblies)
            {
                Soldaduras.AddParteAParteSecundariaTaller(Parte, part);
            }
        }

        public static void AddPartesSueltasAColadaTaller(ArrayList listAssemblies, Part Colada)
        {
            foreach (Part part in listAssemblies)
            {
                //Assembly assembly = part.GetAssembly().GetAssembly();
                //ModelObjectEnumerator modelObjectEnumerator = assembly.GetChildren();
                //foreach (ModelObject part2 in modelObjectEnumerator)
                //{
                //    assembly.Remove(part2);
                //}
             
                AddParteAColadaSubconjuntoTaller(Colada, part);
            }
        }

        public static void AddPartesSueltasAColadaObra(ArrayList listAssemblies, Part Colada)
        {
            foreach (Part part in listAssemblies)
            {
                
                Soldaduras.AddParteAColadaSubconjuntoObra(Colada, part);
            }
        }


        public static void CreaSubConjuntoAddColadaObra(ArrayList listAssemblies, Part Colada, Part primaryPartAssembly, string assemblyName, string assemblyPrefix)
        {
            Soldaduras.AddParteAColadaSubconjuntoObra(Colada, primaryPartAssembly);

            Assembly assembly = primaryPartAssembly.GetAssembly();
            //assembly.SetUserProperty("NAME", assemblyName);
            //assembly.SetUserProperty("PREFIX", assemblyPrefix);
            //assembly.SetUserProperty("SERIAL_NUMBER", 1);


            assembly.Name = assemblyName;
            assembly.AssemblyNumber.Prefix = assemblyPrefix;
            assembly.AssemblyNumber.StartNumber = 1;
            assembly.Modify();


            foreach (Part part in listAssemblies)
            {
                AddParteAColadaSubconjuntoTaller(primaryPartAssembly, part);
            }


        }

        public static void CreaSubConjuntoAddColadaTaller(ArrayList listAssemblies, Part Colada, Part primaryPartAssembly, string assemblyName, string assemblyPrefix)
        {
            foreach (Part part in listAssemblies)
            {
                AddParteAParteSecundariaTaller(primaryPartAssembly, part);
                //AddParteAColadaSubconjuntoTaller(primaryPartAssembly, part);
            }

            AddParteAColadaSubconjuntoTaller(Colada, primaryPartAssembly);

            Assembly assembly = primaryPartAssembly.GetAssembly();

            assembly.Name = assemblyName;
            assembly.AssemblyNumber.Prefix = assemblyPrefix;
            assembly.AssemblyNumber.StartNumber = 1;
            assembly.Modify();
            
            //Assembly assembly = primaryPartAssembly.GetAssembly();
            //assembly.SetUserProperty("NAME", assemblyName);
            //assembly.SetUserProperty("PREFIX", assemblyPrefix);
            //assembly.SetUserProperty("SERIAL_NUMBER", 1);

            
        }

        public static void CreaSubConjuntoAddColadaTallerNoReNum(ArrayList listAssemblies, Part Colada, Part primaryPartAssembly, string assemblyName, string assemblyPrefix)
        {
            foreach (Part part in listAssemblies)
            {
                AddParteAParteSecundariaTaller(primaryPartAssembly, part);
            }

            AddParteAColadaSubconjuntoTallerNoReNum(Colada, primaryPartAssembly);


            Assembly assembly = primaryPartAssembly.GetAssembly();

            assembly.Name = assemblyName;
            assembly.AssemblyNumber.Prefix = assemblyPrefix;
            assembly.AssemblyNumber.StartNumber = 1;
            assembly.Modify();
        }

        public static void LimpiaAssembly(Part secondary)
        {

            Beam dummyPart = new Beam();
            dummyPart.StartPoint = new Tekla.Structures.Geometry3d.Point(0, 0);
            dummyPart.EndPoint = new Tekla.Structures.Geometry3d.Point(0, 10);
            dummyPart.Profile.ProfileString = "0*0";
            dummyPart.Insert();

            Assembly subassemblyBeam = dummyPart.GetAssembly();

            subassemblyBeam.Add(secondary.GetAssembly());
            
            dummyPart.Delete();



            subassemblyBeam.Modify();
        }
      

        public static ArrayList BorraPartesdeAssembly(ArrayList listAssemblies)
        {
            ArrayList arrayList = new ArrayList();
            foreach (Part part in listAssemblies)
            {
                Assembly assembly = part.GetAssembly().GetAssembly();
                //ModelObjectEnumerator modelObjectEnumerator = assembly.GetChildren();
                //foreach (ModelObject part2 in modelObjectEnumerator)
                //{
                // if(assembly.Remove(part2))
                //    {
                //        MessageBox.Show("Failed");
                //    }
                //    else
                //    {
                        
                //    }

                //}
                assembly.Delete();
                
                Assembly assembly2 = part.GetAssembly() as Assembly;
                assembly2.AssemblyNumber.Prefix = "";
                assembly2.AssemblyNumber.StartNumber = 0;
                assembly2.Name = part.Name;
                assembly2.Modify();
                arrayList.Add(part);

                //AddParteAColadaSubconjuntoTallerLimpia(Colada, part);
            }
            return arrayList;
        }
    }
}
