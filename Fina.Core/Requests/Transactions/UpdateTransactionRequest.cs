﻿using Fina.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions;

public class UpdateTransactionRequest : Request
{
    public long Id { get; set; }

    [Required(ErrorMessage = "Título inválido")]
    public string Title { get; set; } = string.Empty;


    [Required(ErrorMessage = "Tipo inválido")]
    public EtransactionType Type { get; set; } = EtransactionType.Withdraw;


    [Required(ErrorMessage = "Valor inválido")]
    public decimal Amount { get; set; }


    [Required(ErrorMessage = "Categoria inválida")]
    public long CategoryId { get; set; }


    [Required(ErrorMessage = "Data inválida")]
    public DateTime? PaidOrReceivedAt { get; set; }
}
