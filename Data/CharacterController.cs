using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Dapper;

namespace WebApplication1.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly ConnectionString _connectionString;

        public CharactersController(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }

        // GET: api/Characters
        [HttpGet]
        public IEnumerable<Characters> GetCharacters()
        {
            List<Characters> CharactersOutput = new List<Characters>();
            using(MySqlConnection con = new MySqlConnection(_connectionString.MySQL))
            {
                var output = con.Query<Characters>("SELECT * FROM Characters");

                CharactersOutput = output.AsList();
            }
            
            return CharactersOutput;
            // return await _connectionString.CharactersOutput.ToListAsync();
        }
        
        // GET: api/Characters/5
        [HttpGet("{id}")]
        public Characters GetCharacters(int id)
        {
            Characters character = new Characters();

            using(MySqlConnection con = new MySqlConnection(_connectionString.MySQL))
            {
                string query = string.Format("SELECT * FROM Characters WHERE Id = {0};", id);

                var output = con.Query<Characters>(query);

                character = output.FirstOrDefault();
            }

            if (character == null)
            {
                return new Characters();
            }

            return character;
        }

        // POST: api/Characters
        [HttpPost]
        public void PostCharacters(Characters characters)
        {
            string query = $"" +
                "INSERT INTO `Characters`" +
                "(`Id`, `CharName`, `Class`, `Race`, `IsAlive`, `Proficiency`)" +
                "VALUES" +
                ($"({characters.Id},") +
                ("\"" + $"{characters.CharName}" + "\",") +
                ("\"" + $"{characters.Class}" + "\",") +
                ("\"" + $"{characters.Race}" + "\",") +
                ($"{characters.IsAlive},") +
                ($"{characters.Proficiency})");
            using(MySqlConnection con = new MySqlConnection(_connectionString.MySQL))
            {
                // con.Query(query);
                con.Execute(query);
            }
        } 

        // PUT: api/Characters/Put
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut]
        public void PutCharacters(Characters characters)
        {
            string query = $"" +
                "UPDATE `Alboria`.`Characters` " +
                "SET " +
                ($"`Id` = {characters.Id},") +
                ("`CharName` = \"" + $"{characters.CharName}" + "\",") +
                ("`Class` = \"" + $"{characters.Class}" + "\",") +
                ("`Race` = \"" + $"{characters.Race}" + "\",") +
                ($"`IsAlive` = {characters.IsAlive},") +
                ($"`Proficiency` = {characters.Proficiency} ") +
                $" WHERE `Id` = {characters.Id};";
            using(MySqlConnection con = new MySqlConnection(_connectionString.MySQL))
            {
                // con.Query(query);
                con.Execute(query);
            }
        } 

        // DELETE 
        [HttpDelete]
        public void DeleteCharacter(Characters charId)
        {
            string query = "" +
            "DELETE FROM `Alboria`.`Characters`" + 
            $"WHERE `Id` = {charId.Id}";

            using(MySqlConnection con = new MySqlConnection(_connectionString.MySQL))
            {
                con.Execute(query);
            }
        }

        // GET: api/characters/stats
        [HttpGet("Stats")]
        public IEnumerable<Characters> GetCharactersStats()
        {
            List<Characters> CharactersOutput = new List<Characters>();

            string query = "" +
                "SELECT CharName, Characters.Class, (Health*Proficiency) as Health, (Mana*Proficiency) as Mana , " +
                "(Strength*Proficiency) as Strength, (Agility*Proficiency) as Agility, (Magic*Proficiency) as Magic " +
	            "FROM Alboria.Characters " +
	            "inner join ClassStats on Characters.Class = ClassStats.Class; ";

            using(MySqlConnection con = new MySqlConnection(_connectionString.MySQL))
            {
                var output = con.Query<Characters>(query);

                CharactersOutput = output.AsList();
            }
            
            return CharactersOutput;
        }

    }
}