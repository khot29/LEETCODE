// What i have done

/**
 * @param {Array} arr
 * @param {number} size
 * @return {Array}
 */

var chunk = function(arr, size) {
   let total_array_division = Math.ceil(arr.length / size);

    let start = 0;
    let end = size;
    let result = [];
    for(let i = 0; i < total_array_division; i++){
            if(i <= total_array_division - 1){
                result.push(arr.slice(start, end));
            }else{
                result.push(arr.slice(end));
            }
            start += size;
            end += size;
    }

    return result;
};


// What Actually it should be 

/**
 * @param {Array} arr
 * @param {number} size
 * @return {Array}
 */
var chunk = function(arr, size) {
    let result = [];
    for(let i = 0; i < arr.length; i+=size){
        result.push(arr.slice(i, i+size));
    }
    return result;
};
