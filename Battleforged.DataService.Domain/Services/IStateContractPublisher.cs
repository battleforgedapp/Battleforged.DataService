using Battleforged.DataService.Domain.Abstractions;
using Battleforged.DataService.Domain.Contracts;

namespace Battleforged.DataService.Domain.Services;

/// <summary>
/// Service in charge of publishing the ability state contract to the message broker/pipeline.
/// </summary>
public interface IStateContractPublisher {

    /// <summary>
    /// Publish the current state of an ability domain model onto the message stream.
    /// </summary>
    /// <param name="contract">The state contract to publish.</param>
    /// <param name="ct">The current request cancellation token.</param>
    /// <returns></returns>
    Task PublishAsync<T>(T contract, CancellationToken ct = default) where T : class, IStateContract;
}