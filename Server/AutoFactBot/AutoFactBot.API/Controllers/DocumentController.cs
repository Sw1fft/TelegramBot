using AutoFactBot.Core.Abstractions;
using AutoFactBot.API.Contracts;
using Microsoft.AspNetCore.Mvc;
using AutoFactBot.Core.Models;

namespace AutoFactBot.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentsService _documentsService;

        public DocumentController(IDocumentsService documentsService)
        {
            _documentsService = documentsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Response>>> GetDocuments()
        {
            var documents = await _documentsService.GetAllDocuments();

            var response = documents.Select(b => new Response(b.Id, b.Title, b.Description));
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateDocument([FromBody] Request request)
        {
            var (document, error) = DocumentModel.Create(Guid.NewGuid(), request.Title, request.Description);

            if (!string.IsNullOrEmpty(error))
                return BadRequest(error);

            var documentId = await _documentsService.CreateDocument(document);
            return Ok(documentId);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> UpdateDocument(Guid id, [FromBody] Request request)
        {
            var documentId = await _documentsService.UpdateDocument(id, request.Title, request.Description);

            return Ok(documentId);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Guid>> DeleteDocument(Guid id)
        {
            var documentId = await _documentsService.DeleteDocument(id);

            return Ok(documentId);
        }
    }
}
