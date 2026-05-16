using BlogPostApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogPostApplication.Controllers;

public class BlogController : Controller
{
    private readonly ILogger<BlogController> _logger;

    public BlogController(ILogger<BlogController> logger)
    {
        _logger = logger;
    }

    // League of Legends Champions Database
    private static readonly List<Post> MockChampions = new()
    {
        new Post 
        { 
            Id = 1, 
            Title = "Ahri", 
            Role = "Mid",
            Author = "Mage/Assassin",
            Difficulty = "Medium",
            Type = "Mage",
            ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ahri_0.jpg",
            Content = "Ahri is a nine-tailed fox mage who prowls Runeterra's mystical heart seeking the magic to understand her prey—and herself. A trickster by nature, she exels at seduction and deception, using her supernatural charm to beguile her targets before striking with swift magical force. In the League of Legends, she is known for her mobility, crowd control, and burst damage potential.", 
            CreatedAt = DateTime.UtcNow.AddDays(-7) 
        },
        new Post 
        { 
            Id = 2, 
            Title = "Garen",
            Role = "Top",
            Author = "Tank/Fighter",
            Difficulty = "Easy",
            Type = "Fighter",
            ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Garen_0.jpg",
            Content = "Garen spins to win! This warrior of Demacia is known for his powerful sword strikes and Judgment ability. Garen excels in the top lane with his tankiness and sustained damage. He's an excellent choice for beginners due to his straightforward playstyle. His ultimate ability, Demacian Justice, delivers massive true damage to a single enemy.", 
            CreatedAt = DateTime.UtcNow.AddDays(-5) 
        },
        new Post 
        { 
            Id = 3, 
            Title = "Lux",
            Role = "Support/Mid",
            Author = "Mage/Support",
            Difficulty = "Easy",
            ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lux_0.jpg",
            Type = "Mage",
            Content = "Lux, the Lady of Luminosity, is a young mage from Demacia with the rare gift of magical affinity. Armed with her wand and protective light, she uses her magic to protect allies and devastate enemies. Her signature Final Spark ability creates a powerful laser that can eliminate targets from a distance. Perfect for players who want to control teamfights.",
            CreatedAt = DateTime.UtcNow.AddDays(-3) 
        },
        new Post 
        { 
            Id = 4, 
            Title = "Yasuo",
            Role = "Mid/Top",
            Author = "Assassin/Fighter",
            Difficulty = "Hard",
            ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Yasuo_0.jpg",
            Type = "Swordsman",
            Content = "Yasuo, the Unforgiven, is a high-skill-cap champion who wields a katana with deadly precision. His Wind Wall blocks incoming projectiles, and his Teleport/Dash combo allows him to engage and disengage fights rapidly. Steel Tempest can be chained for massive area damage. Mastering Yasuo requires significant practice but rewards players with flashy, exciting plays.",
            CreatedAt = DateTime.UtcNow.AddDays(-1) 
        },
        new Post 
        { 
            Id = 5, 
            Title = "Thresh",
            Role = "Support",
            Author = "Support/Tank",
            Difficulty = "Hard",
            ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Thresh_0.jpg",
            Type = "Support",
            Content = "Thresh is the Chain Warden, a ghostly jailer who binds enemies with his chains. His ability to hook enemies with Death Sentence makes him one of the most impactful support champions in the game. With high skill expression and crowd control, Thresh can turn teamfights around single-handedly. His Dark Passage lantern also provides shields and mobility for teammates.",
            CreatedAt = DateTime.UtcNow.AddDays(-2) 
        },
        new Post 
        { 
            Id = 6, 
            Title = "Ashe",
            Role = "ADC",
            Author = "Marksman",
            Difficulty = "Medium",
            Type = "Marksman",
            ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ashe_0.jpg",
            Content = "Ashe is a master archer and the Frost Archer of Freljord. She deals consistent physical damage from a distance and has exceptional utility with her Enchanted Crystal Arrow ultimate. Her Hawkshot ability reveals enemy positions, making her a great choice for controlling map vision. Perfect for players who want to deal sustained damage while staying safe.",
            CreatedAt = DateTime.UtcNow.AddDays(-4) 
        }
    };

    // Index action - displays list of all League of Legends champions
    public IActionResult Index()
    {
        try
        {
            _logger.LogInformation("Champions list requested");
            return View(MockChampions);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving champions");
            return StatusCode(500);
        }
    }

    // Details action - displays details for a single champion
    public IActionResult Details(int id)
    {
        try
        {
            _logger.LogInformation("Champion details requested for id: {ChampionId}", id);
            
            var champion = MockChampions.FirstOrDefault(p => p.Id == id);
            
            if (champion == null)
            {
                _logger.LogWarning("Champion with id {ChampionId} not found", id);
                return NotFound();
            }

            return View(champion);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving champion details");
            return StatusCode(500);
        }
    }
}
