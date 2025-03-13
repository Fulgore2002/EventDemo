/*
 * Stock Prices (Event Handlers)
 * Tyler Hitchcock
 * 3/12/25
 * credit: help from my brother Trent
 */

using System;

namespace EventDemo
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Programming II Stock Prices (Event Handlers) by Tyler Hitchcock";
            Exchange exchange = new Exchange();
            exchange.Open();
        }
    }
}
