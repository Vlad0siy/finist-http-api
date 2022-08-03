using FinistAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinistAPI.Controllers
{
    [Route("[controller]")]
    public class FinistDBController : Controller
    {
        private AppDatabaseContext _context;
        public FinistDBController(AppDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Card> Get() => _context.Cards.Select(x => x).ToList();

        [HttpGet("{id}")]
        public IEnumerable<Card> Get(int id) => _context.Cards.Find(id) as IEnumerable<Card>;

        [HttpGet("{type}")]
        public IEnumerable<CardType> GetTypes() => _context.CardTypes.Select(x => x).ToList();

        [HttpPost]
        public void Post([FromBody]string value)
        {
            Card card = new Card();
            card.Ammount = 0.0m;
            card.ExpirationDate = DateTime.UtcNow;
            card.Code = "0000000000000000";
            card.AccountId = 0;
            card.Icon = new byte[0];
            _context.Cards.Add(card);
            _context.SaveChanges();
        }
    }
}
