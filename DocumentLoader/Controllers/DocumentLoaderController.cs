using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DocumentLoader.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentLoaderController : ControllerBase
    {
        private readonly ILogger<DocumentLoaderController> _logger;

        public DocumentLoaderController(ILogger<DocumentLoaderController> logger)
        {
            _logger = logger;
        }

    }
}
