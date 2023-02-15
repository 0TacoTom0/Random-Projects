function BubbleSort(array){
    for(let i = 0; i <= array.length-1; i++){
        let swapped=false
        for(let j = 0; j <= array.length-1; j++){
            if(array[j]>array[j+1]){
                let temp = array[j]
                let temp2 = array[j+1]
                array[j] = temp2
                array[j+1] = temp
                swapped=true
            }
        }
        if(!swapped){
            break
        }
    }
    return array
}

numbers = [4, 2, 1, 12, 6, 8]
console.log(BubbleSort(numbers))