using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XmlToModel.Mapping;
using XmlToModel.Models;

namespace XmlToModel.Dtos
{
    public class GetCarsDto : IMapFrom<XmlPattern.Cars>
    {
            public XmlPattern.Car[] Car { get; set; }
    }
}
