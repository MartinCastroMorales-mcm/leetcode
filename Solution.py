class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        left = 0
        right = len(nums) -1
        sorted(nums)
        while(True):
            currentValue = nums[left] + nums[right]
            if(currentValue > target):
                right = right -1
            elif(currentValue < target):
                left = left + 1
            else:
                return [left, right]

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        pass