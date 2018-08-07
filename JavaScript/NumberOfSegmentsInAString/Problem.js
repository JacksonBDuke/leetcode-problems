/*
    Author: Jackson Duke

    Problem     - https://leetcode.com/problems/number-of-segments-in-a-string/
    Submission  - https://leetcode.com/submissions/detail/168070597/
    Details
        Status: Accepted
        Submitted: August 7, 2018
        26/26 test cases passed
        Runtime: 48ms
        Notes: "Your runtime beats 100.00 % of javascript submissions."
 */

/**
 * @param {string} s
 * @returns {number}
 */

var countSegments = function(s){
  // s = s.replace(/ +(?=)/g,' ');
  s = s.replace(/\s{2,}/g, ' ').trim();
  return s.length <= 0 ? 0 : s.split(' ').length;
};