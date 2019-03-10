using AutoMapper;
using System.Collections.Generic;

public static class MapperUtil
{
    public static TTarget CreateMapped<TSource, TTarget>(this TSource aSource) where TTarget : new()
    {
        Mapper.Initialize(cfg => cfg.CreateMap<TSource, TTarget>());
        return Mapper.Map<TSource, TTarget>(aSource);
    }

    public static List<TTarget> CreateMappedList<TSource, TTarget>(this List<TSource> aSource) where TTarget : new()
    {
        Mapper.Initialize(cfg => cfg.CreateMap<TSource, TTarget>());
        return Mapper.Map<List<TSource>, List<TTarget>>(aSource);
    }
}