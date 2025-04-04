﻿using System.ComponentModel.DataAnnotations;

namespace ticketHub_function;

public class Purchase
{
    public int ConcertId { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string CreditCard { get; set; } = string.Empty;
    public string Expiration { get; set; } = string.Empty;
    public string SecurityCode { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Province { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
}