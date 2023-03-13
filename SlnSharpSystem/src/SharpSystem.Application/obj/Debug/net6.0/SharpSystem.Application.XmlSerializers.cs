[assembly:System.Security.AllowPartiallyTrustedCallers()]
[assembly:System.Security.SecurityTransparent()]
[assembly:System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
[assembly:System.Xml.Serialization.XmlSerializerVersionAttribute(ParentAssemblyId=@"34ebd3e6-0462-42e2-ab54-d131a8daf749,", Version=@"1.0.0.0")]
namespace Microsoft.Xml.Serialization.GeneratedAssembly {

    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write4_WebServiceAPI(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"WebServiceAPI", @"");
                return;
            }
            TopLevelElement();
            Write2_WebServiceAPI(@"WebServiceAPI", @"", ((global::SharpSystem.Application.Services.WebServiceAPI)o), true, false);
        }

        public void Write5_ConverterBase64(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ConverterBase64", @"");
                return;
            }
            TopLevelElement();
            Write3_ConverterBase64(@"ConverterBase64", @"", ((global::SharpSystem.Application.Helper.ConverterBase64)o), true, false);
        }

        void Write3_ConverterBase64(string n, string ns, global::SharpSystem.Application.Helper.ConverterBase64 o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::SharpSystem.Application.Helper.ConverterBase64)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ConverterBase64", @"");
            WriteEndElement(o);
        }

        void Write2_WebServiceAPI(string n, string ns, global::SharpSystem.Application.Services.WebServiceAPI o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::SharpSystem.Application.Services.WebServiceAPI)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"WebServiceAPI", @"");
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read4_WebServiceAPI() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id1_WebServiceAPI && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read2_WebServiceAPI(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":WebServiceAPI");
            }
            return (object)o;
        }

        public object Read5_ConverterBase64() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id3_ConverterBase64 && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read3_ConverterBase64(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ConverterBase64");
            }
            return (object)o;
        }

        global::SharpSystem.Application.Helper.ConverterBase64 Read3_ConverterBase64(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_ConverterBase64 && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::SharpSystem.Application.Helper.ConverterBase64 o;
            o = new global::SharpSystem.Application.Helper.ConverterBase64();
            System.Span<bool> paramsRead = stackalloc bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        global::SharpSystem.Application.Services.WebServiceAPI Read2_WebServiceAPI(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_WebServiceAPI && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::SharpSystem.Application.Services.WebServiceAPI o;
            o = new global::SharpSystem.Application.Services.WebServiceAPI();
            System.Span<bool> paramsRead = stackalloc bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id1_WebServiceAPI;
        string id3_ConverterBase64;
        string id2_Item;

        protected override void InitIDs() {
            id1_WebServiceAPI = Reader.NameTable.Add(@"WebServiceAPI");
            id3_ConverterBase64 = Reader.NameTable.Add(@"ConverterBase64");
            id2_Item = Reader.NameTable.Add(@"");
        }
    }

    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    public sealed class WebServiceAPISerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WebServiceAPI", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write4_WebServiceAPI(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read4_WebServiceAPI();
        }
    }

    public sealed class ConverterBase64Serializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ConverterBase64", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write5_ConverterBase64(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read5_ConverterBase64();
        }
    }

    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System.Collections.Hashtable readMethods = null;
        public override System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"SharpSystem.Application.Services.WebServiceAPI::"] = @"Read4_WebServiceAPI";
                    _tmp[@"SharpSystem.Application.Helper.ConverterBase64::"] = @"Read5_ConverterBase64";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.Hashtable writeMethods = null;
        public override System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"SharpSystem.Application.Services.WebServiceAPI::"] = @"Write4_WebServiceAPI";
                    _tmp[@"SharpSystem.Application.Helper.ConverterBase64::"] = @"Write5_ConverterBase64";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.Hashtable typedSerializers = null;
        public override System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp.Add(@"SharpSystem.Application.Services.WebServiceAPI::", new WebServiceAPISerializer());
                    _tmp.Add(@"SharpSystem.Application.Helper.ConverterBase64::", new ConverterBase64Serializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::SharpSystem.Application.Services.WebServiceAPI)) return true;
            if (type == typeof(global::SharpSystem.Application.Helper.ConverterBase64)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::SharpSystem.Application.Services.WebServiceAPI)) return new WebServiceAPISerializer();
            if (type == typeof(global::SharpSystem.Application.Helper.ConverterBase64)) return new ConverterBase64Serializer();
            return null;
        }
    }
}
