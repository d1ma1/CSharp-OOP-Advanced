using OnlineRadioDatabase.ErrorMessages;
using System;
using System.Collections.Generic;

namespace OnlineRadioDatabase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<Song>();
            var duration = new TimeSpan(0, 0, 0);

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var line = input.Split(new[] { ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (input.Split(';').Length != 3)
                    {
                        throw new InvalidSongException();
                    }
                    if (input.Split(':').Length != 2)
                    {
                        throw new InvalidSongLengthException();
                    }

                    var mins = line[2];
                    var secs = line[3];

                    int minutes = 0;
                    int seconds = 0;

                    bool isMins = int.TryParse(mins, out minutes);
                    bool isSecs = int.TryParse(secs, out seconds);

                    if (!isMins && !isSecs)
                    {
                        throw new InvalidSongLengthException();
                    }

                    var song = new Song(line[0], line[1], int.Parse(line[2]), int.Parse(line[3]));

                    list.Add(song);
                    Console.WriteLine("Song added.");

                    duration += new TimeSpan(0, int.Parse(line[2]), int.Parse(line[3]));
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Songs added: " + list.Count);
            Console.WriteLine($"Playlist length: {duration.Hours}h {duration.Minutes}m {duration.Seconds}s");
        }
    }
}
