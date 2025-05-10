function processTemperatureQueries(n, q, temperatures, queries) {
    // Step 1: Build prefix sum array
    const prefixSum = new Array(n + 1).fill(0);
    for (let i = 0; i < n; i++) {
        prefixSum[i + 1] = prefixSum[i] + temperatures[i];
    }

    // Step 2: Process each query
    for (let i = 0; i < q; i++) {
        const [l, r] = queries[i];
        const total = prefixSum[r] - prefixSum[l - 1];
        const count = r - l + 1;
        const average = total / count;
        console.log(average.toFixed(2));
    }
}

// ✅ Example Input
const n = 5;
const q = 3;
const temperatures = [2, 4, 6, 8, 10];
const queries = [
    [1, 3],
    [2, 5],
    [1, 5]
];

// ✅ Run the function
processTemperatureQueries(n, q, temperatures, queries);




function proceTemp(n,q,tempereture,query){
    const prefixSums = new Array(n+1).fill(0)
    for(let i=0; i<n; i++){
        prefixSums.push(prefixSums[i]+temperatures[i])
    }

    for(let [l,r] of query){
        let sum = prefixSums[r] - prefixSums[l-1];
        let avg = sum / (r-l+1);
        console.log(avg.toFixed(2));
    }
}

proceTemp(
    5, 3,
    [2, 4, 6, 8, 10],
    [[1, 3], [2, 5], [1, 5]]
);