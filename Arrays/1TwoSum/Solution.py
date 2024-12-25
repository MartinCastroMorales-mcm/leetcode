class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:

        myMap = {}
        for i in range(0, len(nums)):
            n = nums[i]
            myMap[n] = i
            if((target - n) in myMap):
                return[i, myMap[target-n]]
        return [0,0]