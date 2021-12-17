using System.Linq;

using EfCore.Data.PostgreSQL;
using EfCore.Data.SqlServer;
using EfCore.Domain;

var _postgreSqlDbContext = new PostgreSqlDbContext();
var _sqlServerDbContext = new SqlServerDbContext();

var leagueA = new League
{
    Name = "League A"
};

var leagueB = new League
{
    Name = "League B"
};

var leagueC = new League
{
    Name = "League C"
};

if (_postgreSqlDbContext.Leagues.Any() == false)
{
    _postgreSqlDbContext.Leagues.Add(leagueA);
    _postgreSqlDbContext.Leagues.Add(leagueB);
    await _postgreSqlDbContext.SaveChangesAsync();
}

if (_sqlServerDbContext.Leagues.Any() == false)
{
    _sqlServerDbContext.Leagues.Add(leagueA);
    _sqlServerDbContext.Leagues.Add(leagueB);
    _sqlServerDbContext.Leagues.Add(leagueC);
    await _sqlServerDbContext.SaveChangesAsync();
}
