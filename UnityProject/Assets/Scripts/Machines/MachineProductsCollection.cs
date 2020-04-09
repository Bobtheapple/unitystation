﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MachineProductsCollection", menuName = "ScriptableObjects/Machines/MachineProductsCollection")]
public class MachineProductsCollection : ScriptableObject
{
	[SerializeField]
	[Tooltip("A list of product categories.")]
	private List<MachineProductList> productCategoryList = new List<MachineProductList>();

	public List<MachineProductList> ProductCategoryList { get => productCategoryList; }
}

[System.Serializable]
public class MachineProductList
{
	[SerializeField]
	[Tooltip("Category name for a list of products.")]
	private string categoryName;

	public string CategoryName { get => categoryName; }

	[SerializeField]
	[Tooltip("The list of products in this category")]
	private List<MachineProduct> products = new List<MachineProduct>();

	public List<MachineProduct> Products { get => products; }
}

[System.Serializable]
public class MachineProduct
{
	[SerializeField]
	[Tooltip("Product name.")]
	private string name;

	public string Name { get => name; }

	[SerializeField]
	[Tooltip("Product Prefab")]
	private GameObject product;

	public GameObject Product { get => product; }

	[SerializeField]
	[Tooltip("Product material cost")]
	public List<MachineProductMaterialPrice> materialPrice = new List<MachineProductMaterialPrice>();

	public List<MachineProductMaterialPrice> MaterialPrice { get => materialPrice; }
}

//This is used to define material price of materials for a certain product. If
//items get a component holding the value, this should be refactored.
[System.Serializable]
public class MachineProductMaterialPrice
{
	[SerializeField]
	[Tooltip("The material type, materials have an item trait according to their types.")]
	public ItemTrait material;

	public ItemTrait Material { get => material; }

	[Tooltip("The amount of materials the product costs.")]
	public int amount;

	public int Amount { get => amount; }
}