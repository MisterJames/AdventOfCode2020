using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace AoC2020
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args) 
        {
            var services = ServiceProviderBuilder.GetServiceProvider();
            var cookieSettings = services.GetRequiredService<IOptions<CookieSettings>>().Value;

            var downloader = new InputLoader(cookieSettings);

            //Console.WriteLine("Day 1:  " + new Day01().SolvePuzzle(await downloader.Download("https://adventofcode.com/2020/day/1/input")));
            //Console.WriteLine("Day 1b: " + new Day01b().SolvePuzzle(await downloader.Download("https://adventofcode.com/2020/day/1/input")));

            //Console.WriteLine("Day 2:  " + new Day02().SolvePuzzle(await downloader.Download("https://adventofcode.com/2020/day/2/input")));
            //Console.WriteLine("Day 2b:  " + new Day02b().SolvePuzzle(await downloader.Download("https://adventofcode.com/2020/day/2/input")));

            Console.WriteLine("Day 3:  " + new Day03().SolvePuzzle(await downloader.Download("https://adventofcode.com/2020/day/3/input")));

        }


    }





}
