using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using XmlToModel.Dtos;
using XmlToModel.Models;
using static XmlToModel.Models.XmlPattern;

namespace XmlToModel.Services
{
    public class XmlService : IXmlService
    {
        private readonly IMapper _mapper;

        public XmlService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public GetCarsDto CreateModel(string uploadedFile)
        {
            var clearedXml = CleanXmlFile(uploadedFile);
            return DeserializeXmlFile(clearedXml);
        }

        private XElement CleanXmlFile(string stringFile)
        {
            var xmlFile = XElement.Parse(stringFile);

            foreach (XElement xe in xmlFile.DescendantsAndSelf())
            {
                xe.Name = xe.Name.LocalName;
                xe.ReplaceAttributes(from xattrib in xe.Attributes().Where(xa => !xa.IsNamespaceDeclaration) select new XAttribute(xattrib.Name.LocalName, xattrib.Value));
            }

            return xmlFile;
        }

        private GetCarsDto DeserializeXmlFile(XElement xmlFile)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Cars));
            string updatedStringFile = xmlFile.ToString();
            Cars xmlPattern = (Cars)serializer.Deserialize(new StringReader(updatedStringFile));
            return _mapper.Map<GetCarsDto>(xmlPattern);
        }
    }
}
