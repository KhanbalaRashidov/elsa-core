using Elsa.Alterations.Core.Contracts;
using Elsa.Alterations.Core.Entities;
using Elsa.Alterations.Core.Filters;
using Elsa.Common.Services;

namespace Elsa.Alterations.Core.Stores;

/// <summary>
/// A memory-based store for alteration jobs.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="MemoryAlterationJobStore"/> class.
/// </remarks>
public class MemoryAlterationJobStore(MemoryStore<AlterationJob> store) : IAlterationJobStore
{
    private readonly MemoryStore<AlterationJob> _store = store;

    /// <inheritdoc />
    public Task SaveAsync(AlterationJob job, CancellationToken cancellationToken = default)
    {
        _store.Save(job, x => x.Id);
        return Task.CompletedTask;
    }

    /// <inheritdoc />
    public Task SaveManyAsync(IEnumerable<AlterationJob> jobs, CancellationToken cancellationToken = default)
    {
        _store.SaveMany(jobs, x => x.Id);
        return Task.CompletedTask;
    }

    /// <inheritdoc />
    public Task<AlterationJob?> FindAsync(AlterationJobFilter filter, CancellationToken cancellationToken = default)
    {
        var entity = _store.Query(query => Filter(query, filter)).FirstOrDefault();
        return Task.FromResult(entity);
    }

    /// <inheritdoc />
    public Task<IEnumerable<AlterationJob>> FindManyAsync(AlterationJobFilter filter, CancellationToken cancellationToken)
    {
        var entities = _store.Query(query => Filter(query, filter)).ToList().AsEnumerable();
        return Task.FromResult(entities);
    }

    /// <inheritdoc />
    public Task<IEnumerable<string>> FindManyIdsAsync(AlterationJobFilter filter, CancellationToken cancellationToken = default)
    {
        var ids = _store.Query(query => Filter(query, filter)).Select(x => x.Id).ToList().AsEnumerable();
        return Task.FromResult(ids);
    }

    /// <inheritdoc />
    public Task<long> CountAsync(AlterationJobFilter filter, CancellationToken cancellationToken = default)
    {
        var count = _store.Query(query => Filter(query, filter)).LongCount();
        return Task.FromResult(count);
    }


    private static IQueryable<AlterationJob> Filter(IQueryable<AlterationJob> query, AlterationJobFilter filter) => filter.Apply(query);
}