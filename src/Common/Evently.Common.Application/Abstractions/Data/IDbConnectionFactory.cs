using System.Data.Common;

namespace Evently.Common.Application.Abstractions.Data;
public interface IDbConnectionFactory
{
    ValueTask<DbConnection> OpenConnectionAsync();
}
