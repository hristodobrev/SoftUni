class LoginView
{
    constructor() {
        this.html = `
        <section id="login-view" class="login-view">
        <h2>Login</h2>
        <br>
          <form id="login-form">
            <div class="form-group">
              <label for="username">Username</label>
              <input type="text" class="form-control" name="username" id="username" aria-describedby="usernameHelp" placeholder="Username">
            </div>
            <div class="form-group">
              <label for="password">Password</label>
              <input type="password" class="form-control" name="password" id="password" placeholder="Password" />
            </div>
            <button type="submit" class="btn btn-primary">Login</button>
          </form>
        </section>
        `;
        return this;
    }
}
