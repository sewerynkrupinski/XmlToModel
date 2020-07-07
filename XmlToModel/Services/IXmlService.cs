using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static XmlToModel.Models.XmlPattern;

namespace XmlToModel.Services
{
    public interface IXmlService
    {
        Cars CreateModel(string uploadedFile);
    }
}
