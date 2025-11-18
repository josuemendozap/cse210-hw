using System;
using System.Collections.Generic;

class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _rand = new Random();

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();

        _scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5),
            "Trust in the Lord with all thine heart, and lean not unto thine own understanding."
        ));

        _scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        ));

        _scriptures.Add(new Scripture(
            new Reference("1 Nephi", 3, 7),
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
        ));

        _scriptures.Add(new Scripture(
            new Reference("2 Nephi", 4, 20, 21),
            "My God hath been my support; he hath led me through mine afflictions in the wilderness; and he hath preserved me upon the waters of the great deep. He hath filled me with his love, even unto the consuming of my flesh."
        ));
    }

    public Scripture GetRandomScripture()
    {
        int index = _rand.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
