class Solution(object):
    def threeSum(self, nums):
        result = []
        for i in range(len(nums)-2):
            OnePtr = nums[i]
            for j in range(i+1, len(nums) -1):
                TwoPrt = nums[j]
                for k in range(j+1, len(nums)):
                    ThreePrt = nums[k]
                    if(OnePtr + TwoPrt + ThreePrt == 0):
                        triplet = [OnePtr, TwoPrt, ThreePrt]
                        mbool = self.IsTripletRepeated(result, triplet)
                        if(mbool):
                            resutl.append([OnePtr, TwoPrt, ThreePrt])
                        
        
        return result

    def IsTripletRepeated(result, triplet):
        for i in range(len(result)):
            if(self.areTripletsEqual(triplet, result[i])):
                return true

        return false
            

    def areTripletsEqual(triplet1, triplet2):
        for i in range(3):
                if(not (triplet1[i] == triplet2[0] or triplet1[i] == triplet2[1] or triplet1[i] == triplet2[2])) :
                    return false
        return true

"""
:type nums: List[int]
:rtype: List[List[int]]
"""
            