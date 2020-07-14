using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XmlToModel.Services;
using static XmlToModel.Models.XmlPattern;

namespace XmlToModel.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class XmlController : ControllerBase
    {
        private readonly IXmlService _xmlService;

        public XmlController(IXmlService xmlService)
        {
            _xmlService = xmlService;
        }

        [HttpPost("uploadXmlFiles")]
        public async Task<IActionResult> UploadXmlFiles(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);
            var loggedUser = User.Claims.ToList();

            var models = new List<Cars>();
            foreach (var file in files)
            {
                string uploadedFile = string.Empty;

                if (file.Length > 0 && file.ContentType == "text/xml")
                {
                    try
                    {
                        using (var reader = new StreamReader(file.OpenReadStream()))
                        {
                            uploadedFile = await reader.ReadToEndAsync();
                        }
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }
                }
                else
                {
                    return BadRequest("Wrong format");
                }

                var model = _xmlService.CreateModel(uploadedFile);
                models.Add(model);
            }

            return Ok(models);
        }
    }
}