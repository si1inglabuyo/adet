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

    private static readonly List<Post> MockChampions = new()
    {
        new Post
        {
            Id = 1,
            Title = "Ahri — The Nine-Tailed Fox",
            Author = "Revi Ocasion",
            Content = "Ahri is a mobile mage assassin who uses charm and burst magic to pick off targets. A versatile mid-laner, she excels at mobility and outplay potential, making her a popular champion for players who enjoy high-skill spell combos."
        },
        new Post
        {
            Id = 2,
            Title = "Garen — Might of Demacia",
            Author = "Seth Evardo",
            Content = "Garen is a durable top-lane juggernaut who trades simply and effectively. With strong sustain and a powerful execute ultimate, he represents the classic beginner-friendly champion that punishes mistakes and dominates extended trades."
        },
        new Post
        {
            Id = 3,
            Title = "Lux — Lightbringer of Demacia",
            Author = "Althea Gatchalian",
            Content = "Lux is a control mage with long-range poke and a game-changing ultimate. She thrives in both mid and support roles, bringing shields and crowd-control tools that enable her team to win fights from range."
        },
        new Post
        {
            Id = 4,
            Title = "Yasuo — The Unforgiven",
            Author = "Liezel Tamparong",
            Content = "Yasuo is a high-skill champion focused on mobility and outplay mechanics. His kit rewards precise timing and positioning, allowing skilled players to carry games through mechanical prowess and smart map play."
        },
        new Post
        {
            Id = 5,
            Title = "Thresh — The Chain Warden",
            Author = "Raphael Latoy",
            Content = "Thresh is a playmaking support who hooks and repositions enemies while protecting allies with his lantern. His skill ceiling is high, offering massive reward to players who land precise hooks and flay timings."
        },
        new Post
        {
            Id = 6,
            Title = "Ashe — The Frost Archer",
            Author = "Den Mateo",
            Content = "Ashe is a utility marksman who shapes the map with slows and global crowd control. Her ultimate can initiate fights or catch out-of-position enemies, making her a strategic pick for coordinated play."
        }
    };

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
