// created on 8/28/2005 at 11:58 PM
using System;
using System.Collections;

struct Title {
	public int Namespace;
	public string Text;
	
	public Title(string prefixedTitle, IDictionary namespaces) {
		foreach (int key in namespaces.Keys) {
			string prefix = (string)namespaces[key];
			int len = prefix.Length;
			if (len > 0
				&& (prefixedTitle.Length - len) > 1
				&& prefixedTitle.StartsWith(prefix)
				&& prefixedTitle[len] == ':') {
				Namespace = key;
				Text = Title.ValidateTitleChars(prefixedTitle.Substring(len + 1));
				return;
			}
		}
		Namespace = 0;
		Text = prefixedTitle;
	}
	
	public static string ValidateTitleChars(string text) {
		// FIXME
		return text;
	}
}
