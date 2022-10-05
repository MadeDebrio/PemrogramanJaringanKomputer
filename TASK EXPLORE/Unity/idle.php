<?php
	
	//game loop
	$isPlay = true;

	//Array of integer to store money, each array store one digit (0-9)
	$money[24]=0;

	//Integer to store temporary amount of money
	$temp = 0;

	//Varible for increment
	$waveLoops = 3000;
  $randomValue=rand(0,10);
	//Loop for array definition
	for ($i = 0; $i <= 24; $i++) {
		$money[$i] = 0;
	}
	

	//Start loop
	while ($isPlay) {
		//Add random amount of money at index addFromIndex
		$money[0] += rand(0,100);

		//checking digit of array for data manipulation
		for ($i = 0; $i <= 24; $i++) {

			if ($money[$i] > 9) {

				$temp = $money[$i]/10;
				//$temp /= 10;
				$money[$i + 1] = $money[$i + 1] + $temp;
				$money[$i] = $money[$i] - $temp * 10;
			}
		}

		//print out
		for ($i = 23; $i >= 0; $i--) {	
			echo $money[$i];
		}

		echo "\n";

		$waveLoops--;

		//branch for increment
		if ($waveLoops == 0) {
			if ($randomValue < 100000) {
				$randomValue *= 10;
			}
			else {
				$randomValue = 4294967295;
			}
			$waveLoops = 3000;
		}
		
	}

?>
