/*
public IList<IList<string>> GroupAnagrams(string[] strs) { 
            List<Dictionary<char, int>> listAnagramGroups = new();
            List<IList<string>> listResult = new();
            foreach(string s in strs) {
                if(IsInOneOfTheGroups(listAnagramGroups, s, listResult)) {
                    
                }else {
                    Dictionary<char, int> newMap = createGroup(s);
                    listAnagramGroups.Add(newMap);
                    List<string> newList = new();
                    newList.Add(s);
                    listResult.Add(newList);
                }

            }
            return listResult;
        }
        public bool IsInOneOfTheGroups(List<Dictionary<char, int>> ListOfmap, string s, List<IList<string>> listResult) {
            for(int i = 0; i < ListOfmap.Count; i++) {
                    if(IsAnagram(s, ListOfmap[i])) {
                        listResult[i].Add(s);
                        return true;
                    }else {
                        
                    }
                }
            return false;
        }

        public Dictionary<char, int> createGroup(string s)
        {
            Dictionary<char, int> map = new();
            int value = 0;
            foreach (char c in s)
            {
                if (!map.TryGetValue(c, out value))
                {
                    map.Add(c, 1);
                }
                else
                {
                    value++;
                    map[c] = value;
                }
            }
            Console.WriteLine("map of the string: " + s);
            this.printMap(map);
            return map;
        }

        public bool IsAnagram(string s, Dictionary<char, int> map)
        {
            Console.WriteLine("\n\nIsAnagram: " + s);
            this.printMap(map);
            Dictionary<char, int> map2 = new();
            int value = 0;
            int charactersInMap;
            
            if (s.Length != map.Count)
            {
                Console.WriteLine("return false, diferent size");
                return false;
            }
            foreach (char c in s)
            {
                if(!map.TryGetValue(c, out value)) {
                    Console.WriteLine("diferent characters return false");
                    return false;
                }
                if (!map2.TryGetValue(c, out value))
                {
                    map2.Add(c, 1);
                }
                else
                {
                    value++;
                    map2[c] = value;
                }
            }
            foreach(char c in s) {
                if(map[c] != map2[c]) {
                    Console.WriteLine("diferent amount of characters return false: " + "c: " + c+ "map[c]: " + map[c] + "map2[c]: " + map2[c]);
                    return false;
                }
            }
            Console.WriteLine("return true");
            return true;
        }
        public void printMap(Dictionary<char, int> map)
        {
            Dictionary<char, int>.KeyCollection charList = map.Keys;
            foreach (char c in charList)
            {
                int value = 0;
                map.TryGetValue(c, out value);
                Console.WriteLine("char: " + c + " value: " + value);
            }
        }

*/