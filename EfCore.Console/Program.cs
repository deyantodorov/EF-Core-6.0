using System.Linq;

using EfCore.Data.PostgreSQL;
using EfCore.Data.SqlServer;
using EfCore.Domain;

var postgreSqlDbContext = new PostgreSqlDbContext();
var sqlServerDbContext = new SqlServerDbContext();

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

if (postgreSqlDbContext.Leagues.Any() == false)
{
    await postgreSqlDbContext.Leagues.AddAsync(leagueA);
    await postgreSqlDbContext.Leagues.AddAsync(leagueB);
    await postgreSqlDbContext.SaveChangesAsync();
}

if (sqlServerDbContext.Leagues.Any() == false)
{
    await sqlServerDbContext.Leagues.AddAsync(leagueA);
    await sqlServerDbContext.Leagues.AddAsync(leagueB);
    await sqlServerDbContext.Leagues.AddAsync(leagueC);
    await sqlServerDbContext.SaveChangesAsync();
}
