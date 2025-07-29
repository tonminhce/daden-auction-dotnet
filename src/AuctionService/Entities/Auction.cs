using System;

namespace AuctionService.Entities;

public class Auction
{
    public Guid Id { get; set; }

    public int ReservePrice { get; set; } = 0;

    public string Seller { get; set; }

    public string Consignor { get; set; }

    public string Winner { get; set; }

    public int? FinalPrice { get; set; }

    public int? CurrentHighestBid { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public AuctionStatus Status { get; set; }

    public AuctionItem Item { get; set; }
}