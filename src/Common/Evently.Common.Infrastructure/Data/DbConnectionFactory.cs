using Evently.Common.Application.Abstractions.Data;
using Npgsql;
using System.Data.Common;

namespace Evently.Common.Infrastructure.Data;
internal sealed class DbConnectionFactory(NpgsqlDataSource dataSource) : IDbConnectionFactory
{
    public async ValueTask<DbConnection> OpenConnectionAsync()
    {
        return await dataSource.OpenConnectionAsync();
    }
}
