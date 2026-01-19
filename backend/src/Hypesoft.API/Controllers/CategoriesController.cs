using MediatR;
using Microsoft.AspNetCore.Mvc;
using Hypesoft.Application.Commands.CreateCategory;
using Hypesoft.Application.Queries.GetCategories;

namespace Hypesoft.API.Controllers;

[ApiController]
[Route("api/categories")]
public class CategoriesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CategoriesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCategoryCommand command)
    {
        var id = await _mediator.Send(new CreateCategoryCommand(command.Name));
        return Ok(id);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var data = await _mediator.Send(new GetCategoriesQuery());
        return Ok(data);
    }
}
