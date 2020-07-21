using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XmlToModel.Dtos;
using static XmlToModel.Models.XmlPattern;

namespace XmlToModel.Services
{
    public interface IXmlService
    {
        GetCarsDto CreateModel(string uploadedFile);
    }
}
