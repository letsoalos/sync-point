using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class AssetsController(DataContext context) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Asset>>> GetAssets()
    {
        return await context.Assets.ToListAsync();
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Asset>> GetAsset(int id)
    {
        var asset = await context.Assets.FindAsync(id);

        if (asset == null) return NotFound();

        return asset;
    }

    [HttpPost]
    public async Task<ActionResult<Asset>> CreateAsset(Asset asset)
    {
        context.Add(asset);

        await context.SaveChangesAsync();

        return asset;
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> UpdateAsset(int id, Asset asset)
    {
        if (asset.Id != id || !AssetExists(id)) return BadRequest("Cannot update this asset");

        context.Entry(asset).State = EntityState.Modified;

        await context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteAsset(int id)
    {
        var asset = await context.Assets.FindAsync(id);

        if (asset == null) return NotFound();

        context.Assets.Remove(asset);

        await context.SaveChangesAsync();

        return NoContent();
    }

    private bool AssetExists(int id)
    {
        return context.Assets.Any(x => x.Id == id);
    }
}
