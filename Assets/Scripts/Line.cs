using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {
	public LineRenderer lineRender;
	public EdgeCollider2D edgeCol;
	List<Vector2> points;

	public void UpdateLine(Vector2 point){
		if(points == null){
			points= new List<Vector2>();
			SetPoints(point);
			return;
		}

		if(Vector2.Distance(points.Last(),point) >  .1f)
			SetPoints(point);
		
	}

	void SetPoints(Vector2 point){
		points.Add (point);

		lineRender.numPositions = points.Count;
		lineRender.SetPosition (points.Count -1,point);
		if(points.Count > 1)
		edgeCol.points = points.ToArray();
	}
}
