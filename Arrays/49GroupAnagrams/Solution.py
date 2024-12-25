

class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if(len(s) != len(t)):
            return False
        hashmap = {}
        
        for c in s:
            if(c in hashmap):
                hashmap[c] = hashmap[c] + 1
            else:
                hashmap[c] = 1
        othermap = {}
        for c in t:
            if(c in othermap):
                othermap[c] = othermap[c] + 1
            else:
                othermap[c] = 1
        
        for c in s:
            try:
                if(hashmap[c] != othermap[c]):
                    return False
            except:
                return False

            
        
        return True

sol = Solution()
boolean = sol.isAnagram("rat", "car")
print(boolean)