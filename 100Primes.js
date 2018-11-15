function firstHundredPrimes(){
	
	var output = new Array();
	var count = 0;
	
	function isPrime(n) {
		var limit = Math.round(Math.sqrt(n));
		
		if (n < 2) {
			return false;
		}
		else if (n == 2) {
			return true;
		}
		else if (n % 2 == 0) {
			return false;
		}
		
		
		for (var count = 3; count <= limit; count++) {
			if (count % 2 == 0) {
				;
			}
			else if (n % count == 0) {
				return false;
			}
		}
		
		return true;
		
	}
	
	while (output.length < 100) {
		if (isPrime(count) == true) {
			output.push(count);
			count = count + 1;
		}
		else {
			count = count + 1;
		}
	}
	
	return output;
}
	