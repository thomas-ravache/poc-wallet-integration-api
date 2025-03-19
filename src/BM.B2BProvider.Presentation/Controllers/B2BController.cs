using BM.B2BProvider.Application.DTOs;
using BM.B2BProvider.Application.UseCases.CancelTransaction;
using BM.B2BProvider.Application.UseCases.GetBalance;
using BM.B2BProvider.Application.UseCases.PerformCredit;
using BM.B2BProvider.Application.UseCases.PerformDebit;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BM.B2BProvider.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class B2BController : ControllerBase
{
    private readonly IMediator _mediator;

    public B2BController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("balance")]
    public async Task<IActionResult> GetBalance([FromBody] GetBalanceCommand command)
    {
        BalanceResponseDto response = await _mediator.Send(command);

        return Ok(response);
    }

    [HttpPost("debit")]
    public async Task<IActionResult> PerformDebit([FromBody] PerformDebitCommand command)
    {
        TransferResponseDto response = await _mediator.Send(command);

        return Ok(response);
    }

    [HttpPost("credit")]
    public async Task<IActionResult> PerformCredit([FromBody] PerformCreditCommand command)
    {
        TransferResponseDto response = await _mediator.Send(command);

        return Ok(response);
    }

    [HttpPost("cancel")]
    public async Task<IActionResult> CancelTransaction([FromBody] CancelTransactionCommand command)
    {
        await _mediator.Send(command);

        return NoContent();
    }
}