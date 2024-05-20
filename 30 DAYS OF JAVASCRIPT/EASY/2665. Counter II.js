/**
 * @param {integer} init
 * @return { increment: Function, decrement: Function, reset: Function }
 */
var createCounter = function (init) {
  let counterValue = init;
  return {
    increment: () => ++counterValue,
    decrement: () => --counterValue,
    reset: () => {
      counterValue = init;
      return counterValue;
    },
  };
};

/**
 * const counter = createCounter(5)
 * counter.increment(); // 6
 * counter.reset(); // 5
 * counter.decrement(); // 4
 */
