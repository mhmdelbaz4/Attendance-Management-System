using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_Management_System.Models
{
    internal class XMLControl
    {
        private static string XML_PATH  = Directory.GetParent("./../../../..")?.FullName + "/xml/attendance.xml";

        public static string GetXMLPath()
        {
            return XML_PATH;
        }

        
        public static XmlDocument ReadAllDocument()
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(Directory.GetParent("./../../../..")?.FullName + "/xml/attendance.xml");
            return XmlDoc;
        }

        public static List<string> NodesToList(string nodePath, string target)
        {
            List<string> list = new List<string>();
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNodeList nodeList = XmlDoc.SelectNodes(nodePath);
            foreach (XmlNode node in nodeList)
            {
                list.Add(node.SelectSingleNode(target).InnerText);
            }
            return list;
        }

        //get multiple nodes
        public static XmlNodeList GetMultipleNodes(string nodePath)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            return XmlDoc.SelectNodes(nodePath);
        }
        

        public static List<List<string>> MultibleNodesToList(string nodepath, string target, params string[] targets)
        {
            List<List<string>> list = new List<List<string>>();
            list.Add(NodesToList(nodepath, target));

            foreach (string t in targets)
            {
                list.Add(NodesToList(nodepath, t));
            }
            return list;
        }

        public static XmlNode? GetNode(string nodePath, string target, string value)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            return GetNode(XmlDoc, nodePath, target, value);
        }

        public static XmlNode? GetNode(XmlDocument XmlDoc, string nodePath, string target, string value)
        {
            string xPath = $"{nodePath}[{target}='{value}']";
            XmlNode? userNode = XmlDoc.SelectSingleNode(xPath);
            return userNode;
        }
        //add node
        public static void AddNode(string nodePath, string[] targets, string[] values)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNode root = XmlDoc.DocumentElement;
            XmlNode? node = root.SelectSingleNode(nodePath);
            if (node != null)
            {
                XmlNode newNode = XmlDoc.CreateElement(nodePath.Split('/')[nodePath.Split('/').Length - 1]);
                for (int i = 0; i < targets.Length; i++)
                {
                    XmlNode target = XmlDoc.CreateElement(targets[i]);
                    target.InnerText = values[i];
                    newNode.AppendChild(target);
                }
                node.AppendChild(newNode);
                XmlDoc.Save(Directory.GetParent("./../../../..")?.FullName + "/xml/attendance.xml");
            }
        }
        //update node
        public static void UpdateNode(string nodePath, string target, string value, string newValue)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNode? node = GetNode(XmlDoc, nodePath, target, value);
            if (node != null)
            {
                node.SelectSingleNode(target).InnerText = newValue;
                XmlDoc.Save(Directory.GetParent("./../../../..")?.FullName + "/xml/attendance.xml");
            }
        }
        //delete node
        public static void DeleteNode(string nodePath, string target, string value)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNode? node = GetNode(XmlDoc, nodePath, target, value);
            if (node != null)
            {
                node.ParentNode?.RemoveChild(node);
                XmlDoc.Save(Directory.GetParent("./../../../..")?.FullName + "/xml/attendance.xml");
            }
        }

        

    }
}
