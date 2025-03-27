using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using System.Collections.ObjectModel;

namespace RevisionModelos.Extensions
{
    public static class DocumentExtension 
    {
        public static List<Element> GetViews (this Document document)
        {
            //codigo obtencion de vistas
            FilteredElementCollector collector = new FilteredElementCollector(document);
            List<Element> views = collector.OfClass(typeof(View)).ToElements().ToList();

            return views;
        }
        public static List<Element> GetSheets(this Document document)
        {
            //codigo obtencion de planos
            FilteredElementCollector collector = new FilteredElementCollector(document);
            List<Element> sheets = collector.OfClass(typeof(ViewSheet)).ToElements().ToList();
            return sheets;
        }
        public static List<Element> GetInstances(this Document document)
        {
            //codigo obtencion de instancias
            List<Element> instances = new List<Element>();

            FilteredElementCollector collector = new FilteredElementCollector(document);
            List<Element> Types = collector.OfClass(typeof(FamilyInstance)).ToElements().ToList();
            foreach (Element inst in Types)
            {
                instances.Add(inst);
            }

            return instances;
        }
        public static List<Element> GetFamily(this Document document)
        {
            //codigo obtencion de instancias
            List<Element> familias = new List<Element>();

            FilteredElementCollector collector = new FilteredElementCollector(document);
            List<Element> familys = collector.OfClass(typeof(Family)).ToElements().ToList();
            foreach (Family fam in familys)
            {
                familias.Add(fam);
            }

            return familias;
        }
        public static List<string> GetCategoryFamily(this Document document)
        {
            //codigo obtencion de instancias
            List<string> categorias = new List<string>();

            FilteredElementCollector collector = new FilteredElementCollector(document);
            List<Element> familias = collector.OfClass(typeof(Family)).ToElements().ToList();
            foreach (Family cat in familias)
            {
                categorias.Add(cat.FamilyCategory.Name);
            }
            return categorias;
        }
        public static string GetCategoryName(this Document document, long id)
        {
            ElementId numberId = new ElementId(id);

            string categoriaNombre = Category.GetCategory(document, numberId).Name;

            return categoriaNombre;
        }
        public static List<string> GetCategoryParameters(this Document document, BuiltInCategory category)
        {
            List<string> parameterNames = new List<string>();

            FilteredElementCollector collector = new FilteredElementCollector(document);
            collector.OfCategory(category);
            collector.WhereElementIsNotElementType();

            Element element = collector.FirstElement();
            if (element != null)
            {
                foreach (Parameter parameter in element.Parameters)
                {
                    parameterNames.Add(parameter.Definition.Name);
                }
            }

            return parameterNames;
        }
        public static List<string> GetParameterDefinitions(this Document document)
        {
            List<string> parameterDefinitions = new List<string>();

            BindingMap parameterBindings = document.ParameterBindings;

            DefinitionBindingMapIterator iterator = (DefinitionBindingMapIterator)parameterBindings.GetEnumerator();
            iterator.Reset();

            while (iterator.MoveNext())
            {
                Definition definition = iterator.Key as Definition;
                if (definition != null)
                {
                    parameterDefinitions.Add(definition.Name);
                }
            }

            return parameterDefinitions;
        }
        public static List<string> GetInstanceBinding(this Document document)
        {
            List<string> parameterDefinitions = new List<string>();

            BindingMap parameterBindings = document.ParameterBindings;

            DefinitionBindingMapIterator iterator = (DefinitionBindingMapIterator)parameterBindings.GetEnumerator();
            iterator.Reset();

            while (iterator.MoveNext())
            {
                Definition definition = iterator.Key as Definition;
                Binding instance = parameterBindings.get_Item(definition);

                

            }

            return parameterDefinitions;
        }
    }
}
