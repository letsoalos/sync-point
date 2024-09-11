using System;
using System.Text.Json;
using Core.Entities;
using Core.Entities._LookUps;

namespace Infrastructure.Data;

public class DataContextSeed
{
    public static async Task SeedAsync(DataContext context)
    {
        if (!context.AssetBrands.Any())
        {
            var brandsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/assetBrand.json");

            var brands = JsonSerializer.Deserialize<List<AssetBrand>>(brandsData);

            if (brands == null) return;

            context.AssetBrands.AddRange(brands);

            await context.SaveChangesAsync();
        }

        if (!context.AssetTypes.Any())
        {
            var typesData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/assetType.json");

            var types = JsonSerializer.Deserialize<List<AssetType>>(typesData);

            if (types == null) return;

            context.AssetTypes.AddRange(types);

            await context.SaveChangesAsync();
        }

        if (!context.Provinces.Any())
        {
            var provinceData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/province.json");

            var provinces = JsonSerializer.Deserialize<List<Province>>(provinceData);

            if (provinces == null) return;

            context.Provinces.AddRange(provinces);

            await context.SaveChangesAsync();
        }

        if (!context.BinLocations.Any())
        {
            var binLocationsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/binLocation.json");

            var binLocations = JsonSerializer.Deserialize<List<BinLocation>>(binLocationsData);

            if (binLocations == null) return;

            context.BinLocations.AddRange(binLocations);

            await context.SaveChangesAsync();
        }    

        if (!context.Conditions.Any())
        {
            var conditionhData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/condition.json");

            var conditions = JsonSerializer.Deserialize<List<Condition>>(conditionhData);

            if (conditions == null) return;

            context.Conditions.AddRange(conditions);

            await context.SaveChangesAsync();
        }

        if (!context.Conditions.Any())
        {
            var conditionhData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/condition.json");

            var conditions = JsonSerializer.Deserialize<List<Condition>>(conditionhData);

            if (conditions == null) return;

            context.Conditions.AddRange(conditions);

            await context.SaveChangesAsync();
        }

        if (!context.Insurers.Any())
        {
            var insurerhData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/insurer.json");

            var insurers = JsonSerializer.Deserialize<List<Insurer>>(insurerhData);

            if (insurers == null) return;

            context.Insurers.AddRange(insurers);

            await context.SaveChangesAsync();
        }

        if (!context.OwnershipCategories.Any())
        {
            var ownershipCategoryData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/ownershipCategory.json");

            var ownershipCategories = JsonSerializer.Deserialize<List<OwnershipCategory>>(ownershipCategoryData);

            if (ownershipCategories == null) return;

            context.OwnershipCategories.AddRange(ownershipCategories);

            await context.SaveChangesAsync();
        }

        if (!context.Projects.Any())
        {
            var projectData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/project.json");

            var projets = JsonSerializer.Deserialize<List<Project>>(projectData);

            if (projets == null) return;

            context.Projects.AddRange(projets);

            await context.SaveChangesAsync();
        }        

        if (!context.ServiceProviders.Any())
        {
            var serviceProviderData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/serviceProvider.json");

            var serviceProviders = JsonSerializer.Deserialize<List<ServiceProvider>>(serviceProviderData);

            if (serviceProviders == null) return;

            context.ServiceProviders.AddRange(serviceProviders);

            await context.SaveChangesAsync();
        }

        if (!context.Statuses.Any())
        {
            var statusData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/status.json");

            var statuses = JsonSerializer.Deserialize<List<Status>>(statusData);

            if (statuses == null) return;

            context.Statuses.AddRange(statuses);

            await context.SaveChangesAsync();
        }

        if (!context.Branches.Any())
        {
            var branchData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/branch.json");

            var branches = JsonSerializer.Deserialize<List<Branch>>(branchData);

            if (branches == null) return;

            context.Branches.AddRange(branches);

            await context.SaveChangesAsync();
        }

        if (!context.Assets.Any())
        {
            var assetData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/asset.json");

            var assets = JsonSerializer.Deserialize<List<Asset>>(assetData);

            if (assets == null) return;

            context.Assets.AddRange(assets);

            await context.SaveChangesAsync();
        }
    }

}
