using System;
using Refit;

public class ServiceGenerator
{
    public static T createService<T>()
    {
        var adapter = RestService.For<T>("https://api.hitbox.tv");

        return adapter;
    }
}