using System.Collections.Generic;

namespace _211DesignAddAndSearchWordsDataStructure;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        WordDictionary wordDictionary = new WordDictionary();
        wordDictionary.AddWord("bad");
        wordDictionary.AddWord("dad");
        wordDictionary.AddWord("mad");
        wordDictionary.Search("pad"); // return False
        wordDictionary.Search("bad"); // return True
        wordDictionary.Search(".ad"); // return True
        wordDictionary.Search("b.."); // return True
    }

    public class WordDictionary
    {
        Node node = new();

        public class Node
        {
            public Dictionary<char, Node> map = new();
            public List<Node> list = new();
            public char letter;
            public bool IsEndOfWord = false;
        }

        public WordDictionary() { }

        public void AddWord(string word)
        {
            Node aux = this.node;
            Node next = null;
            foreach (char c in word)
            {
                if (aux.map.TryGetValue(c, out next)) { }
                else
                {
                    Node newNode = new Node();
                    newNode.letter = c;
                    aux.map.TryAdd(c, newNode);
                    aux.list.Add(newNode);
                    aux = newNode;
                }
            }
            aux.IsEndOfWord = true;
        }

        public bool Search(string word, Node aux = null, int index = 0)
        {
            if (aux == null)
            {
                aux = this.node;
            }
            char c;
            for (int i = index; i < word.Length; i++)
            {
                c = word[i];
                if (c == '.')
                {
                    foreach (Node leaf in aux.list)
                    {
                        if (Search(word, leaf, i + 1))
                        {
                            return true;
                        }
                    }
                }
                if (!aux.map.TryGetValue(c, out aux))
                {
                    return false;
                }
            }

            if (aux.IsEndOfWord)
            {
                return true;
            }
            return false;
        }
    }
}
