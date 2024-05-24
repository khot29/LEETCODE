/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function (functions) {
  return function (x) {
    let sum = x;
    functions.reverse().forEach((Givenfunction) => {
      sum = Givenfunction(sum);
    });

    return sum;
  };
};

/**
 * const fn = compose([x => x + 1, x => 2 * x])
 * fn(4) // 9
 */


/* -------------------------------------------------------------------- */

/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function(functions) {
    
    return function(x) {
        // If there are no functions, return the input x
        if (functions.length === 0) {
            return x;
        }

        // Apply functions from right to left
        let result = x;
        for (let i = functions.length - 1; i >= 0; i--) {
            result = functions[i](result);
        }

        return result;
    }
};

/**
 * const fn = compose([x => x + 1, x => 2 * x])
 * fn(4) // 9
 */