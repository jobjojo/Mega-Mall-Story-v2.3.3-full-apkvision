using System;
using System.Collections.Generic;

namespace kairo.unity.component;

public interface IComponentContainer
{
	List<UIComponent> Components { get; }

	T AddComponent<T>(T component, UIComponent.DisplayModes mode, int layer = 0) where T : UIComponent;

	T AddComponent<T>(T component) where T : UIComponent;

	void RemoveComponent(UIComponent component);

	T GetComponent<T>() where T : UIComponent;

	T[] GetComponents<T>() where T : UIComponent;

	T GetComponent<T>(string name) where T : UIComponent;

	UIComponent GetComponent(Type type);

	UIComponent[] GetComponents(Type type);

	UIComponent GetComponent(Type type, string name);

	UIComponent GetComponent(string name);
}
