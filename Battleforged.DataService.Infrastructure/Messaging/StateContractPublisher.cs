using Battleforged.DataService.Domain.Abstractions;
using Battleforged.DataService.Domain.Services;
using MassTransit;

namespace Battleforged.DataService.Infrastructure.Messaging;

/// <inheritdoc cref="IStateContractPublisher" />
public sealed class StateContractPublisher(IPublishEndpoint publisher) : IStateContractPublisher {

    /// <inheritdoc cref="IStateContractPublisher.PublishAsync{T}" />
    public async Task PublishAsync<T>(T contract, CancellationToken ct = default) 
        where T : class, IStateContract => await publisher.Publish(contract, ct);
}