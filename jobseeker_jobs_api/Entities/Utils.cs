using System.Xml.Linq;
using System.Xml.Serialization;

namespace jobseeker_jobs_api.Entities
{
	//public static string SerializeToXML(this object obj)
	//{
	//	XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
	//	//Add an empty namespace and empty value
	//	ns.Add("", "");
	//	XmlSerializer xs = new XmlSerializer(obj.GetType());
	//	//Serialize the object with our own namespaces (notice the overload)            
	//	using (StringWriter textWriter = new StringWriter())
	//	{
	//		//serialize xml
	//		xs.Serialize(textWriter, obj, ns);
	//		//eleminates declaration of xml
	//		XDocument xdoc = XDocument.Parse(textWriter.ToString());
	//		xdoc.Declaration = null;
	//		return xdoc.ToString();
	//	}
	//}
}
