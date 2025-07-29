using System;

namespace AuctionService.Entities;

public class AuctionItem
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Color { get; set; }

    public string BodyType { get; set; }

    public string ImageUrl { get; set; }

    public DateTime DateOfBirth { get; set; }
}