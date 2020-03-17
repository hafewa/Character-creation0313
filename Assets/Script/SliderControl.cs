using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// GUIコンポーネントの関数を使用する宣言
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
	// 位置を制御するオブジェクト（Transform）を格納する変数
	public Transform obj;
	// X軸回転を制御するオブジェクト（Transform）を格納する変数
	public Transform objRotX;
	// Y軸回転を制御するオブジェクト（Transform）を格納する変数
	public Transform objRotY;
	// Z軸回転を制御するオブジェクト（Transform）を格納する変数
	public Transform objRotZ;
	// 
	public Transform objScale;

	// X軸座標を制御する Slider オブジェクトを格納する変数
	public Slider sliderPosX;
	// Y軸座標を制御する Slider オブジェクトを格納する変数
	public Slider sliderPosY;
	// Z軸座標を制御する Slider オブジェクトを格納する変数
	public Slider sliderPosZ;
	// X軸回転を制御する Slider オブジェクトを格納する変数
	public Slider sliderRotX;
	// Y軸回転を制御する Slider オブジェクトを格納する変数
	public Slider sliderRotY;
	// Z軸回転を制御する Slider オブジェクトを格納する変数
	public Slider sliderRotZ;

	public Slider sliderScale;

	// X軸座標を制御する処理
	public void ValuePosX()
	{
		// オブジェクトの座標を変数 objPos に格納
		Vector3 objPos = obj.position;
		// スライダーの値を変数 objPos に格納
		objPos.x = sliderPosX.value * 0.01f;
		// 変数 objPos の値をオブジェクトの座標に格納
		obj.position = objPos;
	}

	// Y軸座標を制御する処理
	public void ValuePosY()
	{
		// オブジェクトの座標を変数 objPos に格納
		Vector3 objPos = obj.position;
		// スライダーの値を変数 objPos に格納
		objPos.y = sliderPosY.value * 0.01f; ;
		// 変数 objPos の値をオブジェクトの座標に格納
		obj.position = objPos;
	}

	// Z軸座標を制御する処理
	public void ValuePosZ()
	{
		// オブジェクトの座標を変数 objPos に格納
		Vector3 objPos = obj.position;
		// スライダーの値を変数 objPos に格納
		objPos.z = sliderPosZ.value * 0.01f; ;
		// 変数 objPos の値をオブジェクトの座標に格納
		obj.position = objPos;
	}

	// X軸回転を制御する処理
	public void ValueRotX()
	{
		// スライダーの値をオブジェクトのX軸回転値に格納
		objRotX.eulerAngles = new Vector3(sliderRotX.value * 2, 0, 0);
	}

	// Y軸回転を制御する処理
	public void ValueRotY()
	{
		// スライダーの値をオブジェクトのY軸回転値に格納
		//（親オブジェクトから見た相対的なオイラー角の回転値）
		objRotY.localEulerAngles = new Vector3(0, sliderRotY.value * 2, 0);
	}

	// Z軸回転を制御する処理
	public void ValueRotZ()
	{
		// スライダーの値をオブジェクトのZ軸回転値に格納
		//（親オブジェクトから見た相対的なオイラー角の回転値）
		objRotZ.localEulerAngles = new Vector3(0, 0, sliderRotZ.value * 2);
	}

	// モデルの拡大縮小
	public void ValueScale()
	{
		if(sliderScale.value >= 0)
		{
			objScale.transform.localScale  = new Vector3(sliderScale.value += 0.01f, 0, 0);
		}
		/*else if(sliderScale.value < 0)
		{
			objScale.transform.localScale -= new Vector3(sliderScale.value *  -1 * 0.01f, 0, 0);
		}*/

	}

	// リセット処理(座標値)
	public void ValueResetPos()
	{
		// スライダーの値に 0 を格納
		sliderPosX.value = 0f;
		sliderPosY.value = 0f;
		sliderPosZ.value = 0f;
	}

	// リセット処理(回転値)
	public void ValueResetRot()
	{
		// スライダーの値に 0 を格納
		sliderRotX.value = 0f;
		sliderRotY.value = 0f;
		sliderRotZ.value = 0f;
	}
}