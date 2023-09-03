﻿using Contracts;
using MassTransit;
using MongoDB.Entities;
using SearchService.Models;

namespace SearchService;

public class AuctionDeletedConsumer : IConsumer<AuctionDeleted>
{
    public async Task Consume(ConsumeContext<AuctionDeleted> context)
    {
        Console.WriteLine($"Consuming auction deleted event: {context.Message.Id}");

        var result = await DB.DeleteAsync<Item>(context.Message.Id);

        if (!result.IsAcknowledged)
        {
            throw new MessageException(typeof(AuctionDeleted), "Could not delete the auction from the database");
        }
    }
}
