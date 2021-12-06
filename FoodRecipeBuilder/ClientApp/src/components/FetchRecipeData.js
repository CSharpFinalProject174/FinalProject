import React, { Component } from 'react';

export class FetchRecipeData extends Component {
  static displayName = FetchRecipeData.name;

  constructor(props) {
    super(props);
    this.state = { recipes: [], loading: true };
  }

  componentDidMount() {
    this.populateRecipeData();
  }
  static renderRecipesTable(recipes) {
    console.log(recipes)
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Name</th>
            <th>Preperation Time</th>
            <th>Ingredents</th>
          </tr>
        </thead>
        <tbody>
          {recipes.map(recipe =>
            <tr key={recipe.id}>
              <td>{recipe.recipeName}</td>
              <td>{recipe.prepTime} mins</td>
              <td>{recipe.recipeDescription}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchRecipeData.renderRecipesTable(this.state.recipes);

    return (
      <div>
        <h1 id="tabelLabel" >Recipe Information</h1>
        <p>Here are your favorite Recipes</p>
        {contents}
      </div>
    );
  }

  async populateRecipeData() {
    const response = await fetch('api/recipes');
    const data = await response.json();
    this.setState({ recipes: data, loading: false });
  }
}
